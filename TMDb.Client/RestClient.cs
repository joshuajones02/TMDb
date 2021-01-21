using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TMDb.Client.Configurations;
using TMDb.Client.Constants;

namespace TMDb.Client
{
    public abstract class RestClient : HttpClientWrapper
    {
        private readonly RestClientConfiguration _config;

        public RestClient(Uri baseUrl) : this(baseUrl, RestClientConfiguration.Instance)
        {
        }

        public RestClient(Uri baseUrl, RestClientConfiguration config)
            : base(baseUrl, config) =>
                _config = config;

        internal async Task<TResult> GetAsync<TResult>(Uri uri, JsonSerializerSettings deserializeSettings = null) where TResult : class
        {
            var response = await Client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            var settings = deserializeSettings != null
                ? deserializeSettings
                : _config.RequestSerializationSettings;

            return result.ToObject<TResult>(settings);
        }

        internal Task<TResult> PostJsonAsync<TResult>(Uri uri, string json, JsonSerializerSettings deserializeSettings = null) where TResult : class =>
            SendAsync<TResult>(HttpMethod.Post, uri, json, deserializeSettings);

        internal Task<TResult> DeleteAsync<TResult>(Uri uri, string json, JsonSerializerSettings deserializeSettings = null) where TResult : class =>
            SendAsync<TResult>(HttpMethod.Delete, uri, json, deserializeSettings);

        internal async Task<TResult> SendAsync<TResult>(HttpMethod httpMethod, Uri uri, string json, JsonSerializerSettings deserializeSettings = null) where TResult : class
        {
            HttpResponseMessage response = null;
            var payload = new StringContent(json, Encoding.UTF8, ContentType.Json);

            if (httpMethod == HttpMethod.Post)
            {
                response = await Client.PostAsync(uri, payload);
            }
            else if (httpMethod == HttpMethod.Post)
            {
                var requestMessage = new HttpRequestMessage(httpMethod, uri)
                {
                    Content = payload
                };

                response = await Client.SendAsync(requestMessage);
            }
            else
            {
                throw new ArgumentException(nameof(httpMethod));
            }

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            var settings = deserializeSettings != null
                ? deserializeSettings
                : _config.RequestSerializationSettings;

            return result.ToObject<TResult>(settings);
        }

        ///// ****

        //internal virtual Task<TResponse> SendAsync<TRequest, TResponse>(TRequest request, int[] expectedStatusCodes) where TRequest : RequestBase =>
        //    SendInternal(request);

        //internal virtual Task<T> SendAsync<T>(string path, HttpMethod method, int[] expectedStatusCodes, params ApiParameter[] parameters) =>
        //    SendInternal<T>(path, method, expectedStatusCodes, null, parameters);
        ///// ****

        //internal virtual Task SendAsync(string path, HttpMethod method, int[] expectedStatusCodes, params ApiParameter[] parameters) =>
        //    SendInternal<string>(path, method, expectedStatusCodes, null, parameters);

        //internal virtual Task<T> SendAsync<T>(string path, HttpMethod method, int[] expectedStatusCodes, params ApiParameter[] parameters) =>
        //    SendInternal<T>(path, method, expectedStatusCodes, null, parameters);

        //internal virtual Task SendAsync(string path, HttpMethod method, int[] expectedStatusCodes, Action<HttpResponseMessage, Exception> callback, params ApiParameter[] parameters) =>
        //    SendInternal<string>(path, method, expectedStatusCodes, callback, parameters);

        //internal virtual Task<T> SendAsync<T>(string path, HttpMethod method, int[] expectedStatusCodes, Action<HttpResponseMessage, Exception> callback, params ApiParameter[] parameters) =>
        //    SendInternal<T>(path, method, expectedStatusCodes, callback, parameters);
    }
}