using System;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Authentication;
using System.Threading.Tasks;
using TMDb.Client.Configurations;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public class HttpClientWrapper : IDisposable
    {
        private readonly RestClientConfiguration _config;

        public HttpClientWrapper(Uri baseUrl, RestClientConfiguration config)
        {
            _config = config;

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
            var request  = Client.BuildRequest(method, _config, path, parameters);
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