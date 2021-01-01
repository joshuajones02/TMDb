using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class TVEpisodeDetailsResponse
    {
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("production_code")]
        public int ProductionCode { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("still_path")]
        public string StillPath { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("air_date")]
        public DateTime AirDate { get; set; }

        [JsonProperty("crew")]
        public IEnumerable<Crew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public IEnumerable<GuestStar> GuestStars { get; set; }
    }

    public partial class GuestStar
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }
    }
}