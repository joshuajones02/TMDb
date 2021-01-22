using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVAggregateCreditsCrewJob
    {
        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("job")]
        public string JobJob { get; set; }

        [JsonProperty("episode_count")]
        public int EpisodeCount { get; set; }
    }
}