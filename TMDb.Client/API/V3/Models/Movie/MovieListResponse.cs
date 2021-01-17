using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class MovieListResponse
    {
        [JsonProperty("page")]
        public virtual int Page { get; set; }

        [JsonProperty("total_results")]
        public virtual int TotalResults { get; set; }

        [JsonProperty("total_pages")]
        public virtual int TotalPages { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<MovieListResult> Results { get; set; }
    }

    public class MovieListResult
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("vote_average")]
        public virtual double VoteAverage { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("original_language")]
        public virtual string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("release_date")]
        public virtual DateTime ReleaseDate { get; set; }

        [JsonProperty("genre_ids")]
        public virtual IEnumerable<int> Genres { get; set; }
    }
}