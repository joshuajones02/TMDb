using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class TrendingRequest : TMDbRequest
    {
        public TrendingRequest(int page) =>
            Page = page;

        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }
    }
}