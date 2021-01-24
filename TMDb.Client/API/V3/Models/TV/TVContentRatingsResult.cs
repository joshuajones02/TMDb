using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVContentRatingsResult
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("rating")]
        public virtual float? Rating { get; set; }
    }
}