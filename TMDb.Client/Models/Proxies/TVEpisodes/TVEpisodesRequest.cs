using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesRequest : TMDbRequest
    {
        [JsonProperty("tv_id")]
        [JsonRequired]
        public virtual int TvId { get; set; }

        [JsonProperty("season_number")]
        [JsonRequired]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("episode_number")]
        [JsonRequired]
        public virtual int EpisodeNumber { get; set; }

        // TODO: Refactor, some endpoints don't accept language (i.e. DeleteTVEpisodeRating)
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}