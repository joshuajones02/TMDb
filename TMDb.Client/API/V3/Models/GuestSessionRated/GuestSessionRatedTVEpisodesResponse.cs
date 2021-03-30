﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.GuestSessionRated
{
    public class GuestSessionRatedTVEpisodesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<GuestSessionRatedTVEpisodesItem> Results { get; set; }
    }

    public class GuestSessionRatedTVEpisodesItem : IRatingResponse
    {
        [JsonProperty("rating")]
        public virtual double? Rating { get; set; }

        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("show_id")]
        public virtual int ShowId { get; set; }

        [JsonProperty("episode_number")]
        public virtual int EpisodeNumber { get; set; }

        [JsonProperty("season_number")]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("production_code")]
        public virtual string ProductionCode { get; set; }

        [JsonProperty("still_path")]
        public virtual string StillPath { get; set; }

        [JsonProperty("air_date")]
        public virtual DateTime? AirDate { get; set; }
    }
}