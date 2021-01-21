using Newtonsoft.Json;
using TMDb.Client.API.V3.Models.Changes;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/season/{season_id}/changes")]
    public class TVSeasonsChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "season_id")]
        [JsonRequired]
        public virtual int SeasonId { get; set; }
    }
}