using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class SearchTVResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public SearchTVResult[] Results { get; set; }
    }

    public partial class SearchTVResult
    {
        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

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
        public string OriginalLanguage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public IEnumerable<string> CountryAbbreviations { get; set; }

        [JsonProperty("genre_ids")]
        public IEnumerable<TMDbGenre> Genres { get; set; }
    }
}