using Newtonsoft.Json;
using System;
using TMDb.Client.Models.Proxies.Changes;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesChangesRequest : ChangeListRequest
    {
        [JsonProperty("episode_id")]
        [JsonRequired]
        public virtual int EpisodeId { get; set; }
    }
}