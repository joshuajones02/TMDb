using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchRequest : TMDbRequest
    {
        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }

        [JsonProperty("query")]
        [JsonRequired]
        public string Query { get; set; }
    }
}