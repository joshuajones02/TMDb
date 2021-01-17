using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Trending
{
    public class TrendingRequest : TMDbRequest
    {
        public TrendingRequest(int page) =>
            Page = page;

        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public int Page { get; set; }
    }
}