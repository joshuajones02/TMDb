using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVScreenedTheatricallyResult
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("episode_number")]
        public virtual int EpisodeNumber { get; set; }

        [JsonProperty("season_number")]
        public virtual int SeasonNumber { get; set; }
    }
}