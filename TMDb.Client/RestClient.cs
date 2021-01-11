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

        public RestClient(Uri baseUrl) 
            : this(baseUrl, RestClientConfiguration.Instance)
        {
        }

        public RestClient(Uri baseUrl, RestClientConfiguration config) 
            : base(config.Handler, false)
        {
            _config     = config;
            BaseAddress = baseUrl;
            Timeout     = TimeSpan.FromSeconds(60);
            
            DefaultRequestHeaders.Accept.Add(config.ApplicationJsonHeader);
            DefaultRequestHeaders.Accept.Add(config.TextJsonHeader);
        }

        public async Task<TResult> GetAsync<TResult>(Uri uri, JsonSerializerSettings deserializeSettings = null) where TResult : class
        {
            var response = await GetAsync(uri);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            var settings = deserializeSettings != null 
                ? deserializeSettings 
                : _config.RequestSerializationSettings;

            return JsonConvert.DeserializeObject<TResult>(result, settings);
        }
    }
}