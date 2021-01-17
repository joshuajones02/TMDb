using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class RateValue
    {
        [JsonProperty("value")]
        public virtual int Value { get; set; }
    }
}