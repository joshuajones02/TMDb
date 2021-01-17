using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Trending
{
    public class TrendingRequest : TMDbRequest
    {
        public TrendingRequest(int page) =>
            Page = page;

        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public virtual int Page { get; set; }
    }
}