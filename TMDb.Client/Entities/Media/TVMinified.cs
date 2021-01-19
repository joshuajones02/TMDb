using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Entities.Media
{
    public class TVMinified
    {
        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public double? VoteAverage { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime? FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public List<string> CountryCodes { get; set; }

        [JsonProperty("genre_ids")]
        public List<long> GenreIds { get; set; }
    }
}