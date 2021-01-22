using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVAggregateCreditsCastRole
    {
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("episode_count")]
        public int EpisodeCount { get; set; }
    }
}