using Newtonsoft.Json;
using TMDb.Client.Models.Proxies.Changes;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsChangesRequest : ChangeListRequest
    {
        [JsonProperty("season_id")]
        [JsonRequired]
        public virtual int SeasonId { get; set; }
    }
}