using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;
using TMDb.Client.Entities.Organizations;

namespace TMDb.Client.API.V3.Models.TVEpisodeGroups
{
    public class TVEpisodeGroupsResponse : TMDbCollectionResponse
    {
        [JsonProperty("episode_count")]
        public virtual int EpisodeCount { get; set; }

        [JsonProperty("group_count")]
        public virtual int GroupCount { get; set; }

        [JsonProperty("type")]
        public virtual int Type { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("description")]
        public virtual string Description { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("network")]
        public virtual Network Network { get; set; }

        [JsonProperty("groups")]
        public virtual IEnumerable<EpisodeGroup> Groups { get; set; }
    }
}