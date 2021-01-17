using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class LatestMovieResponse
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("vote_average")]
        public virtual int VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("budget")]
        public virtual int Budget { get; set; }

        [JsonProperty("popularity")]
        public virtual int Popularity { get; set; }

        [JsonProperty("revenue")]
        public virtual int Revenue { get; set; }

        [JsonProperty("runtime")]
        public virtual int Runtime { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual object BackdropPath { get; set; }

        [JsonProperty("belongs_to_collection")]
        public virtual object BelongsToCollection { get; set; }

        [JsonProperty("status")]
        public virtual string Status { get; set; }

        [JsonProperty("tagline")]
        public virtual string Tagline { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("homepage")]
        public virtual string Homepage { get; set; }

        [JsonProperty("release_date")]
        public virtual string ReleaseDate { get; set; }

        [JsonProperty("imdb_id")]
        public virtual string IMDbId { get; set; }

        [JsonProperty("original_language")]
        public virtual string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("genres")]
        public virtual IEnumerable<MovieGenre> Genres { get; set; }

        [JsonProperty("production_companies")]
        public virtual IEnumerable<ProductionCountry> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public virtual IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual IEnumerable<SpokenLanguage> SpokenLanguages { get; set; }
    }
}