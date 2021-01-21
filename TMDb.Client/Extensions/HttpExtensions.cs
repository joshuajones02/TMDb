using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using TMDb.Client.Attributes;
using TMDb.Client.Builders;
using TMDb.Client.Configurations;
using TMDb.Client.Constants;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public static class HttpExtensions
    {
        public static void ValidateStatusCode(this HttpResponseMessage response, HttpRequestMessage request, int[] expectedStatusCodes)
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

        [Obsolete("// TODO: Is 'string path' needed if RestParameter has ApiEndpoint value?")]
        public static HttpRequestMessage BuildRequest(this HttpClient client, ApiEndpoint endpoint, List<ApiParameter> parameters, IRestClientConfiguration config)
        {
            var uriBuilder          = new UrlBuilder(client.BaseAddress);
            var serializedBody      = default(string);
            var contentType         = default(string);
            var contentTypeInHeader = default(bool);
            var accept              = default(string);
            var request             = new HttpRequestMessage { Method = endpoint.HttpMethod };

            var query = default(List<ApiParameter>);
            var pathParameters = default(List<ApiParameter>);

            foreach (var param in parameters.Where(x => x.Value != null))
            {
                if (param.ParameterType == ParameterType.FormUrlEncodedBody)
                    throw new NotImplementedException("Content-Type 'application/json' has not been yet implemented");
                if (param.ParameterType == ParameterType.XmlBody)
                    throw new NotImplementedException("Content-Type 'application/xhtml+xml' has not been yet implemented");
                // TODO: refactor this so header setting is all together (1 of 3)
                else if (param.ParameterType == ParameterType.Header)
                {
                    if ("accept".Equals(param.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        accept = param.Value.ToString();
                        request.Headers.Add("Accept", accept);
                    }
                    // TODO: Refactor 
                    // content-type header needs to be applied to the request.Content object (see below)
                    else if (param.Name.EqualsIgnoreCase(ContentType.Name))
                    {
                        contentTypeInHeader = true;
                    }
                    else
                    {
                        request.Headers.Add(param.Name, param.Value + "");
                    }
                }
                else if (param.ParameterType == ParameterType.JsonBody)
                {
                    if (serializedBody != null)
                    {
                        throw new ArgumentException("Only one parameter can be specified as a Body parameter.");
                    }

                    serializedBody = param.Value.ToJson();
                    contentType = ContentType.Json;
                }
                else if (param.ParameterType == ParameterType.PathPrepend && param.Value.HasValue())
                {
                    // TODO: *** Move to UriBuilder
                    if (!param.Value.StartsWith('/'))
                        param.Value = "/" + param.Value;
                    if (param.Value.EndsWith('/'))
                        param.Value = param.Value.Remove(param.Value.Length - 1, 1);
                    if (!endpoint.Path.StartsWith('/'))
                        endpoint.Path = "/" + endpoint.Path;

                    endpoint.Path = param.Value + endpoint.Path;
                }
                else if (param.ParameterType == ParameterType.Path)
                {
                    uriBuilder.AddPathParameter(param.Name, param.Value);
                }
                else if (param.ParameterType == ParameterType.Query)
                {
                    uriBuilder.AddQueryParameter(param.Name, param.Value);
                }
            }

            // TODO: Make it more clear in code here that UriBuilder will update the path
            uriBuilder.Path = endpoint.Path;
            request.RequestUri = uriBuilder.Uri;
            request.SetHeader(parameters);

            // TODO: refactor this so header setting is all together (2 of 3)
            if (accept.IsNullOrEmpty())
            {
                request.Headers.Accept.Add(config.ApplicationJsonHeader);
                request.Headers.Accept.Add(config.TextJsonHeader);
            }
            if (serializedBody != null)
            {
                    request.Content = new StringContent(serializedBody, Encoding.UTF8, !contentTypeInHeader ? contentType : null);
            }
            if (!request.Headers.TryGetValues(CustomHeader.RequestId, out var _))
            {
                request.Headers.Add(CustomHeader.RequestId, Guid.NewGuid().ToString());
            }
            foreach (var item in System.Diagnostics.Trace.CorrelationManager.LogicalOperationStack.OfType<object>().Take(10))
            {
                request.Headers.Add(CustomHeader.CorrelationId, item.ToString());
            }

            return request;
        }

        // TODO: refactor this so header setting is all together (3 of 3)
        public static void SetHeader(this HttpRequestMessage request, List<ApiParameter> @params)
        {
            var contentTypeHeader = @params.SingleOrDefault(p => p.ParameterType == ParameterType.Header
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
        }
    }
}