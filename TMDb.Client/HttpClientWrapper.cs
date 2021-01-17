using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using TMDb.Client;
using TMDb.Client.Attributes;
using TMDb.Client.Configurations;
using TMDb.Client.Constants;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public delegate void RequestSendingEventHandler(HttpClientWrapper sender, RequestSendingArguments args);

    public delegate void ResponseReceivedEventHandler(HttpClientWrapper sender, ResponseReceivedArguments args);

    public class RequestSendingArguments
    {
        public int[] ExpectedStatusCodes { get; set; }

        public ApiParameter[] Parameters { get; set; }

        public HttpRequestMessage Request { get; set; }
    }

    public class ResponseReceivedArguments
    {
        public HttpResponseMessage Response { get; set; }

        public object ResponseData { get; set; }

        public Exception Error { get; set; }

        public TimeSpan Duration { get; set; }

        public int[] ExpectedStatusCodes { get; set; }

        // TODO: below had the value inside of it where as the attribute does not.
        // TODO: Make class below and then accept the attribute as a parameter in the constructor
        public ApiParameter[] Parameters { get; set; }

        public HttpRequestMessage Request { get; set; }
    }

    public class HttpClientWrapper : IDisposable
    {
        public static event RequestSendingEventHandler RequestSending;
        public static event ResponseReceivedEventHandler ResponseReceived;
        private readonly RestClientConfiguration _config;
        // TODO: Create builder with local NameValueCollectin for query
        private readonly UriBuilder _uriBuilder;

        public HttpClientWrapper(Uri baseUrl, RestClientConfiguration config)
        {
            _config = config;
            _uriBuilder = new UriBuilder(baseUrl);

            var handler = new HttpClientHandler
            {
                SslProtocols = SslProtocols.Tls12
            };

            Client = new HttpClient(handler)
            {
                BaseAddress = baseUrl,
                MaxResponseContentBufferSize = config.MaxResponseContentBufferSize,
                Timeout = config.Timeout,
            };
        }

        public HttpClient Client { get; protected set; }
        public Uri BaseAddress { get; protected set; }

        protected async Task<T> SendInternal<T>(string path, HttpMethod method, int[] expectedStatusCodes, Action<HttpResponseMessage, Exception> callback, params ApiParameter[] parameters)
        {
            string responseText = null;
            Exception error = null;
            HttpResponseMessage response = null;
            T result = default(T);

            var timer = new Stopwatch();
            var request = BuildRequest(Client, method, path, parameters);

            RequestSending?.Invoke(this, new RequestSendingArguments
            {
                ExpectedStatusCodes = expectedStatusCodes,
                Parameters = parameters,
                Request = request,
            });

            timer.Start();

            try
            {
                response = await Client.SendAsync(request);
                responseText = await response.Content.ReadAsStringAsync();

                ValidateStatusCode(expectedStatusCodes, request, response, responseText);

                result = responseText.ToObject<T>();
            }
            catch (Exception ex)
            {
                error = ex;

                Trace.TraceError("TMDb.Client.HttpClientWrapper : ", ex.ToMinifiedString());

                throw;
            }
            finally
            {
                timer.Stop();

                ResponseReceived?.Invoke(this, new ResponseReceivedArguments
                {
                    Error = error,
                    ExpectedStatusCodes = expectedStatusCodes,
                    Parameters = parameters,
                    Request = request,
                    Response = response,
                    ResponseData = result,
                    Duration = timer.Elapsed
                });

                callback?.Invoke(response, error);
            }

            return result;
        }

        private HttpRequestMessage BuildRequest(HttpClient client, HttpMethod method, string path, params ApiParameter[] parameters)
        {
            string serializedBody = null;
            string contentType = null;
            bool contentTypeInHeader = false;
            string accept = null;

            var request = new HttpRequestMessage
            {
                Method = method,
            };

            parameters = parameters.OrderBy(p =>
            {
                switch (p.ParameterType)
                {
                    case Attributes.ParameterType.JsonBody:
                    case Attributes.ParameterType.FormUrlEncodedBody:
                    case Attributes.ParameterType.XmlBody:
                        return 0;

                    case Attributes.ParameterType.Path:
                        return 1;

                    case Attributes.ParameterType.Query:
                        return 2;

                    case Attributes.ParameterType.Header:
                        return 99;

                    default:
                        return int.MaxValue;
                }
            }).ToArray();

            foreach (var parameter in parameters.Where(x => x.Value != null))
            {
                switch (parameter.ParameterType)
                {
                    case Attributes.ParameterType.JsonBody:
                        if (serializedBody != null)
                        {
                            throw new ArgumentException("Only one parameter can be specified as a Body parameter.");
                        }

                        serializedBody = parameter.Value.ToJson();
                        contentType = "application/json";
                        break;

                    case Attributes.ParameterType.FormUrlEncodedBody:
                        serializedBody = parameter.Value?.ToString();
                        contentType = "application/x-www-form-urlencoded";
                        break;

                    case Attributes.ParameterType.Header:
                        if ("accept".Equals(parameter.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            accept = parameter.Value.ToString();
                            request.Headers.Add("Accept", accept);
                        }
                        else if ("content-type".Equals(parameter.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            contentTypeInHeader = true;
                            continue; // content-type header needs to be applied to the request.Content object (see below)
                        }
                        else
                        {
                            request.Headers.Add(parameter.Name, parameter.Value + "");
                        }
                        break;

                    case Attributes.ParameterType.Path:
                        path = path.Replace($"{{{parameter.Name}}}", WebUtility.UrlEncode(parameter.Value.ToString()));
                        break;

                    case Attributes.ParameterType.Query:
                        var separator = path.Contains('?') ? "&" : "?";
                        path += $"{separator}{parameter.Name}={WebUtility.UrlEncode(parameter.Value.ToString())}";
                        break;
                }
            }

            _uriBuilder.Path = path;
            request.RequestUri = _uriBuilder.Uri;

            if (accept.IsNullOrEmpty())
            {
                request.Headers.Accept.Add(_config.ApplicationJsonHeader);
                request.Headers.Accept.Add(_config.TextJsonHeader);
            }

            if (serializedBody != null)
            {
                if (contentTypeInHeader)
                    request.Content = new StringContent(serializedBody, Encoding.UTF8);
                else
                    request.Content = new StringContent(serializedBody, Encoding.UTF8, contentType);
            }

            var contentTypeHeader = parameters.SingleOrDefault(p => p.ParameterType == Attributes.ParameterType.Header
                                                                 && ContentType.Name.EqualsIgnoreCase(p.Name));
            if (contentTypeHeader != null)
            {
                var parts = contentTypeHeader.Value.ToString()
                    .Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(part => part.Trim())
                    .Where(part => !string.IsNullOrEmpty(part))
                    .ToArray();

                var basic = string.Join(" ", parts.Where(part => !part.Contains('=')));
                var header = new MediaTypeWithQualityHeaderValue(basic);

                foreach (var pair in parts.Where(part => part.Contains('=')))
                {
                    var keyValue = pair.Split('=');
                    if (keyValue.Length != 2)
                    {
                        throw new ArgumentOutOfRangeException("value", $"Unable to parse the content-type header value '{pair}'");
                    }

                    header.Parameters.Add(new NameValueHeaderValue(keyValue[0], keyValue[1]));
                }

                request.Content.Headers.ContentType = header;
            }

            foreach (var item in Trace.CorrelationManager.LogicalOperationStack.OfType<object>().Take(10))
            {
                request.Headers.Add("x-correlation-id", item + "");
            }

            IEnumerable<string> requestIds;
            if (false == request.Headers.TryGetValues("x-request-id", out requestIds))
            {
                request.Headers.Add("x-request-id", Guid.NewGuid().ToString());
            }

            return request;
        }

        // TODO: Attach logId in both the log and error response
        private void ValidateStatusCode(int[] expectedStatusCodes, HttpRequestMessage request, HttpResponseMessage response, string responseText)
        {
            int statusCode = (int)response.StatusCode;

            if (expectedStatusCodes.Contains(statusCode) == false)
            {
                var message = $"(StatusCode {statusCode}) ";
                switch (statusCode)
                {
                    case 404:
                        var requestUrl = request.RequestUri;
                        throw new HttpRequestException(message + $"Could not locate resource at {requestUrl.Host}/{requestUrl.AbsolutePath}");

                    default:
                        message = message + $"Unexpected status code was returned. Expected: {string.Join(",", expectedStatusCodes)}";
                        throw new HttpRequestException();
                }
            }
        }

        public void Dispose()
        {
            if (Client != null)
            {
                Client.Dispose();

                Client = null;
            }
        }
    }
}