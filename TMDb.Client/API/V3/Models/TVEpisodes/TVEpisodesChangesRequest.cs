using Newtonsoft.Json;
using TMDb.Client.API.V3.Models.Changes;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesChangesRequest : ChangeListRequest
    {
        [ApiParameter(
            Name = "episode_id")]
        [JsonRequired]
        public virtual int EpisodeId { get; set; }
    }
}