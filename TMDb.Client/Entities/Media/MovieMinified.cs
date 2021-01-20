using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Contracts;

namespace TMDb.Client.Entities.Media
{
    [Obsolete("// TODO: Replace 'Title' with 'Name' and override JsonProperty to use Title parameter name")]
    public class MovieMinified : IMovieMinified
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("original_language")]
        [Obsolete("// TODO: Rename property to OriginalLanguage")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("release_date")]
        public virtual DateTime? ReleaseDate { get; set; }

        [JsonProperty("genre_ids")]
        [Obsolete("// TODO: Create JSON Converter that will use Genres to fill data")]
        public virtual IEnumerable<int> GenreIds { get; set; }
    }
}