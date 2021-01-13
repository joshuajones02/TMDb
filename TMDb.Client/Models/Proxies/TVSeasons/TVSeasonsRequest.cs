using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsRequest : TMDbRequest
    {
        [JsonIgnore]
        [JsonProperty("tv_id")]
        [JsonRequired]
        public virtual int TvId { get; set; }

        [JsonIgnore]
        [JsonProperty("season_number")]
        [JsonRequired]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}