using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodeGroups
{
    public class TVEpisodeGroupsRequest : TMDbRequest
    {
        [JsonIgnore]
        [ApiParameter(
            Name = "id")]
        public virtual string Id { get; set; }
    }
}