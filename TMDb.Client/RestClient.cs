using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TMDb.Client.Configurations;
using TMDb.Client.Constants;
using TMDb.Client.Models;

namespace TMDb.Client
{
    public class RestClient : HttpClientWrapper
    {
        private readonly RestClientConfiguration _config;

        public RestClient(Uri baseUrl) : this(baseUrl, RestClientConfiguration.Instance)
        {
        }

        public RestClient(Uri baseUrl, RestClientConfiguration config)
            : base(baseUrl, config) =>
                _config = config;

        public async Task<TResult> GetAsync<TResult>(Uri uri, JsonSerializerSettings deserializeSettings = null) where TResult : class
        {
            var response = await Client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            var settings = deserializeSettings != null
                ? deserializeSettings
                : _config.RequestSerializationSettings;

            return result.ToObject<TResult>(settings);
        }

        public Task<TResult> PostJsonAsync<TResult>(Uri uri, string json, JsonSerializerSettings deserializeSettings = null) where TResult : class =>
            SendAsync<TResult>(HttpMethod.Post, uri, json, deserializeSettings);
        
        public Task<TResult> DeleteAsync<TResult>(Uri uri, string json, JsonSerializerSettings deserializeSettings = null) where TResult : class =>
            SendAsync<TResult>(HttpMethod.Delete, uri, json, deserializeSettings);

        public async Task<TResult> SendAsync<TResult>(HttpMethod httpMethod, Uri uri, string json, JsonSerializerSettings deserializeSettings = null) where TResult : class
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

        public virtual Task SendAsync(string path, HttpMethod method, int[] expectedStatusCodes, params ApiParameter[] parameters) =>
            SendInternal<string>(path, method, expectedStatusCodes, null, parameters);

        public virtual Task<T> SendAsync<T>(string path, HttpMethod method, int[] expectedStatusCodes, params ApiParameter[] parameters) =>
            SendInternal<T>(path, method, expectedStatusCodes, null, parameters);

        public virtual Task SendAsync(string path, HttpMethod method, int[] expectedStatusCodes, Action<HttpResponseMessage, Exception> callback, params ApiParameter[] parameters) =>
            SendInternal<string>(path, method, expectedStatusCodes, callback, parameters);

        public virtual Task<T> SendAsync<T>(string path, HttpMethod method, int[] expectedStatusCodes, Action<HttpResponseMessage, Exception> callback, params ApiParameter[] parameters) =>
            SendInternal<T>(path, method, expectedStatusCodes, callback, parameters);
    }
}