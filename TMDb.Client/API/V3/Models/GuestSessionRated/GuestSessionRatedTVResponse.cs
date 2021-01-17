using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    public class GuestSessionRatedTVResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<GuestSessionRatedTVItem> Results { get; set; }
    }

    public class GuestSessionRatedTVItem
    {
        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("rating")]
        public double? Rating { get; set; }

        [JsonProperty("vote_average")]
        public double? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime? FirstAirDate { get; set; }

        [JsonProperty("genre_ids")]
        public IEnumerable<int> GenreIds { get; set; }

        [JsonProperty("origin_country")]
        public IEnumerable<string> OriginCountry { get; set; }
    }
}