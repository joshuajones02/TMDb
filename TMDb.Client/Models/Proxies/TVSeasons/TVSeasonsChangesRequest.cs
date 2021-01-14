using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsChangesRequest : TMDbRequest
    {
        [JsonProperty("page")]
        public virtual int Page { get; set; }

        [JsonProperty("season_id")]
        [JsonRequired]
        public virtual int SeasonId { get; set; }

        [JsonProperty("start_date")]
        public virtual string StartDate { get; set; }

        [JsonProperty("end_date")]
        public virtual string EndDate { get; set; }
    }
}