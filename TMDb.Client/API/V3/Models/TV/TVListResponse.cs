using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVListResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<TVListResult> Results { get; set; }
    }

    public class TVListResult
    {
        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime FirstAirDate { get; set; }

        [JsonProperty("original_language")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> CountryAbbreviations { get; set; }

        [JsonProperty("genre_ids")]
        public virtual IEnumerable<int> Genres { get; set; }
    }
}