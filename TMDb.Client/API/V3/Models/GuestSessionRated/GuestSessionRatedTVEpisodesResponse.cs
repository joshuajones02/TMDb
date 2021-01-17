using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    public class GuestSessionRatedTVEpisodesResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<GuestSessionRatedTVEpisodesItem> Results { get; set; }
    }

    public class GuestSessionRatedTVEpisodesItem
    {
        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("vote_average")]
        public double? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("show_id")]
        public int ShowId { get; set; }

        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("production_code")]
        public string ProductionCode { get; set; }

        [JsonProperty("still_path")]
        public string StillPath { get; set; }

        [JsonProperty("air_date")]
        public DateTime? AirDate { get; set; }
    }
}