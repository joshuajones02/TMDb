using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.TV;

namespace TMDb.Client.Entities
{
    public class Episode
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("episode_number")]
        public virtual int EpisodeNumber { get; set; }

        [JsonProperty("production_code")]
        public virtual int ProductionCode { get; set; }

        [JsonProperty("season_number")]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("still_path")]
        public virtual string StillPath { get; set; }

        [JsonProperty("air_date")]
        public virtual DateTime? AirDate { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<Crew> Crew { get; set; }

        [JsonProperty("guest_stars")]
        public virtual IEnumerable<TVEpisodesGuestStar> GuestStars { get; set; }
    }
}