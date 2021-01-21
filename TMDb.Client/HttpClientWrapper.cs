using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Security.Authentication;
using System.Threading.Tasks;
using TMDb.Client.API;
using TMDb.Client.API.V3.Models;
using TMDb.Client.Attributes;
using TMDb.Client.Builders;
using TMDb.Client.Configurations;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public class HttpClientWrapper : IDisposable
    {
        private readonly IRestClientConfiguration _config;
        private readonly IRequestBuilder _requestBuilder;

        public HttpClientWrapper(Uri baseUrl, RestClientConfiguration config) 
            : this(RequestBuilder.Instance, baseUrl, config)
        {
        }

        public HttpClientWrapper(IRequestBuilder requestBuilder, Uri baseUrl, RestClientConfiguration config)
        {
            _requestBuilder = requestBuilder;
            _config = config;

            var handler = new HttpClientHandler
            {
                SslProtocols = SslProtocols.Tls12
            };

            Client = new HttpClient(handler)
            {
                BaseAddress = baseUrl,
                //MaxResponseContentBufferSize = config.MaxResponseContentBufferSize,
                Timeout = config.Timeout,
            };
        }

        internal HttpClient Client { get; set; }
        internal Uri BaseAddress { get; set; }

        internal virtual Task<TResponse> SendAsync<TResponse>(RequestBase request) where TResponse : TMDbResponse
        {
            var endpoint = _requestBuilder.GetApiEndpoint(request);
            var parameters = _requestBuilder.GetApiParameters(request);

            foreach (var param in parameters)
            {


            }

            var expectedStatusCodes = new int[] { 200, 201 };

            return SendInternal<TResponse>(endpoint, parameters, expectedStatusCodes);
        }

        internal virtual Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request) where TRequest  : RequestBase 
                                                                                          where TResponse : TMDbResponse
        {
            var endpoint = _requestBuilder.GetApiEndpoint(request);
            var parameters = _requestBuilder.GetApiParameters(request);
            var expectedStatusCodes = new int[] { 200, 201 };

            return SendInternal<TResponse>(endpoint, parameters, expectedStatusCodes);
        }

        protected async Task<T> SendInternal<T>(ApiEndpoint endpoint, List<ApiParameter> parameters, int[] expectedStatusCodes)
        {
            var request  = Client.BuildRequest(endpoint, parameters, _config);
            var response = default(HttpResponseMessage);
            var result   = default(T);
            var error    = default(Exception);
            var timer    = new Stopwatch();

            timer.Start();

            try
            {
                response = await Client.SendAsync(request);
                response.ValidateStatusCode(request, expectedStatusCodes);

                var responseText = await response.Content.ReadAsStringAsync();
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

                var responseArguments = new HttpResponseResult
                {
                    Duration                = timer.Elapsed,
                    Error                   = error,
                    ExpectedStatusCodes     = expectedStatusCodes,
                    Parameters              = parameters,
                    Request                 = request,
                    Response                = response,
                    ResponseData            = result
                };

                var log = "TMDb.Client.HttpClientWrapper : " + responseArguments.ToJson();

                if (error != null)
                    Trace.TraceError(log);
                else
                    Trace.TraceInformation(log);
            }

            return result;
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