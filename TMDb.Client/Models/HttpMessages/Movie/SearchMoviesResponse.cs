using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class SearchMoviesResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<SearchMoviesResult> Results { get; set; }
    }

    public partial class SearchMoviesResult
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        [JsonProperty("genre_ids")]
        public IEnumerable<TMDbGenre> Genres { get; set; }
    }
}