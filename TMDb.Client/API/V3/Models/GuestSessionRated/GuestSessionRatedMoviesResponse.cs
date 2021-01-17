using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    public class GuestSessionRatedMoviesResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<GuestSessionRatedMovie> Results { get; set; }
    }

    public class GuestSessionRatedMovie
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("rating")]
        public virtual double? Rating { get; set; }

        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public virtual string OriginalLanguage { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("release_date")]
        public virtual DateTime? ReleaseDate { get; set; }

        [JsonProperty("genre_ids")]
        public virtual IEnumerable<int> GenreIds { get; set; }
    }
}