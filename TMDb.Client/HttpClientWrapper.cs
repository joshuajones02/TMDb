using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using TMDb.Client.API;
using TMDb.Client.API.V3.Models;
using TMDb.Client.Builders;
using TMDb.Client.Extensions;
using TMDb.Client.Configurations;
using TMDb.Client.Models;
using TMDb.Client.Validators;

namespace TMDb.Client
{
    public class HttpClientWrapper : IDisposable
    {
        private readonly IRestClientConfiguration _clientConfiguration;
        private readonly IRequestBuilder _requestBuilder;
        private readonly IStatusCodeValidator _statusCodeValidator;

        public HttpClientWrapper(Uri baseUrl, IRestClientConfiguration config)
            : this(new RequestBuilder(), config, new StatusCodeValidator(), baseUrl)
        {
        }

        public HttpClientWrapper(
            IRequestBuilder requestBuilder,
            IRestClientConfiguration clientConfiguration, 
            IStatusCodeValidator statusCodeValidator, 
            Uri baseUrl)
        {
            _requestBuilder = requestBuilder;
            _clientConfiguration = clientConfiguration;
            _statusCodeValidator = statusCodeValidator;

            var handler = new HttpClientHandler { SslProtocols = SslProtocols.Tls12 };

            Client = new HttpClient(handler)
            {
                BaseAddress = baseUrl,
                //MaxResponseContentBufferSize = config.MaxResponseContentBufferSize,
                Timeout = clientConfiguration.Timeout,
            };

            Client.DefaultRequestHeaders.Accept.Add(clientConfiguration.ApplicationJsonHeader);
            Client.DefaultRequestHeaders.Accept.Add(clientConfiguration.TextJsonHeader);
        }

        internal HttpClient Client { get; set; }
        internal Uri BaseAddress { get; set; }

        internal virtual Task<TResponse> SendAsync<TResponse>(RequestBase request) where TResponse : TMDbResponse
        {
            var endpoint = _requestBuilder.GetApiEndpoint(request);
            var parameters = _requestBuilder.GetApiParameters(request);

            var expectedStatusCodes = new int[] { 200, 201 };

            return SendAsync<TResponse>(endpoint, parameters, expectedStatusCodes);
        }

        protected async Task<T> SendAsync<T>(ApiEndpoint endpoint, List<ApiParameter> parameters, int[] expectedStatusCodes)
        {
            var request = _requestBuilder.BuildRequest(Client.BaseAddress, endpoint, parameters, _clientConfiguration);
            var responseResult = new HttpResponseResult<T>
            {
                ExpectedStatusCodes = expectedStatusCodes,
                Parameters = parameters,
                Request = request, 
                Timer = Stopwatch.StartNew()
            };

            try
            {
                responseResult.Response = await Client.SendAsync(request);
                _statusCodeValidator.ValidateStatusCode(responseResult.Response, request.RequestUri, expectedStatusCodes);
                var responseText = await responseResult.Response.Content.ReadAsStringAsync();
                responseResult.Result = responseText.ToObject<T>();
            }
            catch (Exception ex)
            {
                responseResult.Exception = ex;
                Trace.TraceError("TMDb.Client.HttpClientWrapper : ", ex.ToMinifiedString());

                if (ex.InnerException != null)
                    throw ex.InnerException;

                throw;
            }
            finally
            {
                responseResult.Timer.Stop();

                var log = "TMDb.Client.HttpClientWrapper : " + responseResult.ToJson();

                // TODO: Create logger that switches from app settings
                if (responseResult.Exception != null)
                    Trace.TraceError(log);
                else
                    Trace.TraceInformation(log);
            }

            return responseResult.Result;
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