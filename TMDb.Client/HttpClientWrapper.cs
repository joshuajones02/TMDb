using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using TMDb.Client.Api;
using TMDb.Client.Builders;
using TMDb.Client.Configurations;
using TMDb.Client.Logging;
using TMDb.Client.Validators;

namespace TMDb.Client
{
    public abstract class HttpClientWrapper : IDisposable
    {
        private static readonly LogManager _logger;
        private readonly IRestClientConfiguration _clientConfiguration;
        private readonly IRequestBuilder _requestBuilder;
        private readonly IStatusCodeValidator _statusCodeValidator;

        static HttpClientWrapper()
        {
            _logger = LogManager.GetLogger<HttpClientWrapper>();
        }

        public HttpClientWrapper(Uri baseUrl) : this(RestClientConfiguration.Instance, baseUrl)
        {
        }

        public HttpClientWrapper(IRestClientConfiguration config, Uri baseUrl)
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
                MaxResponseContentBufferSize = _clientConfiguration.MaxResponseContentBufferSize,
                Timeout = clientConfiguration.Timeout,
            };

            Client.DefaultRequestHeaders.Accept.Add(clientConfiguration.ApplicationJsonHeader);
            Client.DefaultRequestHeaders.Accept.Add(clientConfiguration.TextJsonHeader);
        }

        internal HttpClient Client { get; set; }
        internal Uri BaseAddress { get; set; }

        internal virtual async Task<TResponse> SendAsync<TResponse>(RequestBase request) //where TResponse : TMDbResponse
        {
            var expectedStatusCodes = new int[] { 200, 201 };
            var httpRequestMessage = _requestBuilder.BuildRequest(Client.BaseAddress, request, _clientConfiguration);
            var responseResult = new HttpResponseResult<TResponse>
            {
                ExpectedStatusCodes = expectedStatusCodes,
                Request = httpRequestMessage,
                Timer = Stopwatch.StartNew()
            };

            try
            {
                responseResult.Response = await Client.SendAsync(httpRequestMessage);
                _statusCodeValidator.ValidateStatusCode(responseResult.Response, httpRequestMessage.RequestUri, expectedStatusCodes);
                var responseText = await responseResult.Response.Content.ReadAsStringAsync();

                responseResult.Result = responseText.ToObject<TResponse>(_clientConfiguration.ResponseSerializationSettings, true);
            }
            catch (Exception ex)
            {
                responseResult.Exception = ex;
                _logger.LogException(ex);

                if (ex.InnerException != null)
                    throw ex.InnerException;

                throw;
            }
            finally
            {
                responseResult.Timer.Stop();
                _logger.LogInfo(responseResult);
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

            GC.SuppressFinalize(this);
        }
    }
}