using Newtonsoft.Json;
using System;

namespace TMDb.Client.Entities.Media
{
    public class Season
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("season_number")]
        public virtual int? SeasonNumber { get; set; }

        [JsonProperty("episode_count")]
        public virtual int? EpisodeCount { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("air_date")]
        public virtual DateTime? AirDate { get; set; }
    }
}