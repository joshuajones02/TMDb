using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class LatestMovieResponse
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public int VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("budget")]
        public int Budget { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("backdrop_path")]
        public object BackdropPath { get; set; }

        [JsonProperty("belongs_to_collection")]
        public object BelongsToCollection { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDbId { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("genres")]
        public IEnumerable<MovieGenre> Genres { get; set; }

        [JsonProperty("production_companies")]
        public IEnumerable<ProductionCountry> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public IEnumerable<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("spoken_languages")]
        public IEnumerable<SpokenLanguage> SpokenLanguages { get; set; }
    }
}