using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVEpisodeGroups
{
    public class TVEpisodeGroupsRequest : TMDbRequest
    {
        [JsonIgnore]
        [ApiParameter(
            Name = "id")]
        public string Id { get; set; }
    }
}