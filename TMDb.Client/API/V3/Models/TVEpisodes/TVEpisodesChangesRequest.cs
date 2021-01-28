using Newtonsoft.Json;
using TMDb.Client.Api.V3.Models.Changes;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("/tv/episode/{episode_id}/changes")]
    public class TVEpisodesChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "episode_id",
            ParameterType = ParameterType.Path)]
        [JsonRequired]
        public virtual int EpisodeId { get; set; }
    }
}