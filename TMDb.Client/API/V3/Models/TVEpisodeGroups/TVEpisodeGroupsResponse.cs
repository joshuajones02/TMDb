using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.TVEpisodeGroups
{
    public class TVEpisodeGroupsResponse : TMDbResponse
    {
        [JsonProperty("episode_count")]
        public int EpisodeCount { get; set; }

        [JsonProperty("group_count")]
        public int GroupCount { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network")]
        public Network Network { get; set; }

        [JsonProperty("groups")]
        public IEnumerable<EpisodeGroup> Groups { get; set; }
    }
}