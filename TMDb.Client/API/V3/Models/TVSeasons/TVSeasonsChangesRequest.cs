using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "season_id")]
        [JsonRequired]
        public virtual int SeasonId { get; set; }
    }
}