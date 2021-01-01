using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class DiscoverTVResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<TVResult> Results { get; set; }
    }

    public class TVResult
    {
        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime? FirstAirDate { get; set; }

        /// <summary>
        /// Use ConfigurationProxy GetCountries to get full name
        /// </summary>
        [JsonProperty("origin_country")]
        public IEnumerable<string> CountryAbbreviation { get; set; }

        [JsonProperty("genre_ids")]
        public IEnumerable<int> GenreIds { get; set; }
    }
}