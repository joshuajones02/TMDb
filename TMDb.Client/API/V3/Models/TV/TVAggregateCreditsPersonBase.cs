using Newtonsoft.Json;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.TV
{
    public abstract class TVAggregateCreditsPersonBase
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("total_episode_count")]
        public int TotalEpisodeCount { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }
    }
}