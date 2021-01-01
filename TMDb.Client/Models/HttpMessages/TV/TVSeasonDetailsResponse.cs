using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class TVSeasonDetailsResponse : TMDbResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("id")]
        public int SeasonId { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("air_date")]
        public DateTime AirDate { get; set; }

        [JsonProperty("episodes")]
        public IEnumerable<Episode> Episodes { get; set; }
    }

    public partial class Episode
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("episode_number")]
        public int EpisodeNumber { get; set; }

        [JsonProperty("production_code")]
        public int ProductionCode { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("still_path")]
        public string StillPath { get; set; }

        [JsonProperty("air_date")]
        public DateTime AirDate { get; set; }

        [JsonProperty("crew")]
        public IEnumerable<Crew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public IEnumerable<Crew> GuestStars { get; set; }
    }

    public partial class Crew
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("credit_id")]
        public string CreditId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonProperty("character")]
        public string Character { get; set; }

        [JsonProperty("job")]
        public string CrewJob { get; set; }

        [JsonProperty("department")]
        public string CrewDepartment { get; set; }

        [JsonProperty("known_for_department")]
        public string KnownForDepartment { get; set; }
    }
}