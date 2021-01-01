using TMDb.Client.Configurations;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TMDb.Client
{
    public class RestClient : HttpClient
    {
        private readonly RestClientConfiguration _config;

        public RestClient(Uri baseUrl) : this(baseUrl, RestClientConfiguration.Instance)
        {
        }

        public RestClient(Uri baseUrl, RestClientConfiguration config) : base(config.Handler, false)
        {
            _config = config;
            BaseAddress = baseUrl;
            DefaultRequestHeaders.Accept.Add(config.ApplicationJsonHeader);
            DefaultRequestHeaders.Accept.Add(config.TextJsonHeader);
            Timeout = TimeSpan.FromSeconds(60);
        }

        //public Task<TResult> PostUrlFormEncodedBodyAsync<TResult>(Uri uri, IEnumerable<KeyValuePair<string, string>> kvp) =>
        //    Deserialize<TResult>(PostAsync(uri, new FormUrlEncodedContent(kvp)));

        public async Task<TResult> GetAsync<TResult>(Uri uri, JsonSerializerSettings deserializeSettings = null) where TResult : class
        {
            //var response = await GetStringAsync(uri);

            var response = await GetAsync(uri);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            if (deserializeSettings != null)
                    return JsonConvert.DeserializeObject<TResult>(result, deserializeSettings);

                return JsonConvert.DeserializeObject<TResult>(result, _config.RequestSerializationSettings);
        }
    }
}