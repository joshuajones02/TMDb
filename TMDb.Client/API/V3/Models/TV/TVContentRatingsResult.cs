using Newtonsoft.Json;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVContentRatingsResult : IRatingResponse
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("rating")]
        public virtual double? Rating { get; set; }
    }
}