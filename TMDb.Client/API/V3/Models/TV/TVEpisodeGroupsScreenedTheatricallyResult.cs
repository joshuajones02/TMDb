using Newtonsoft.Json;
using TMDb.Client.Entities.Organizations;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVEpisodeGroupsScreenedTheatricallyResult
    {
        [JsonProperty("episode_count")]
        public virtual int EpisodeCount { get; set; }

        [JsonProperty("group_count")]
        public virtual int GroupCount { get; set; }

        [JsonProperty("type")]
        public virtual int Type { get; set; }

        [JsonProperty("description")]
        public virtual string Description { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("network")]
        public virtual Network Network { get; set; }
    }
}