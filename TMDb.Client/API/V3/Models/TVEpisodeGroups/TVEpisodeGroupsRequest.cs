using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodeGroups
{
    [ApiGetEndpoint("/tv/episode_group/{id}")]
    public class TVEpisodeGroupsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "id",
            ParameterType = ParameterType.Path)]
        public virtual string Id { get; set; }
    }
}