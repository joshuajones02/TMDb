using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVEpisodeDetailsResponse
    {
        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("episode_number")]
        public virtual int EpisodeNumber { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("production_code")]
        public virtual int ProductionCode { get; set; }

        [JsonProperty("season_number")]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("still_path")]
        public virtual string StillPath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("air_date")]
        public virtual DateTime AirDate { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<Crew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public virtual IEnumerable<TVEpisodesGuestStar> GuestStars { get; set; }
    }

    public class TVEpisodesGuestStar
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("gender")]
        public virtual int? Gender { get; set; }

        [JsonProperty("known_for_department")]
        public virtual string KnownForDepartment { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }
    }
}