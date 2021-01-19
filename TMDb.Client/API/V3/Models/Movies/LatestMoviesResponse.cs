using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Contracts;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class LatestMoviesResponse : TMDbResponse, IMovie
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public virtual double? VoteAverage { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("budget")]
        public virtual int? Budget { get; set; }

        [JsonProperty("revenue")]
        public virtual int? Revenue { get; set; }

        [JsonProperty("runtime")]
        public virtual int? Runtime { get; set; }

        [JsonProperty("vote_count")]
        public virtual int VoteCount { get; set; }

        [JsonProperty("imdb_id")]
        public virtual string IMDbId { get; set; }

        [JsonProperty("status")]
        public virtual string Status { get; set; }

        [JsonProperty("tagline")]
        public virtual string Tagline { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("original_language")]
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

        [JsonProperty("beints_to_collection")]
        public virtual CollectionMinified Collection { get; set; }

        [JsonProperty("homepage")]
        public virtual Uri Homepage { get; set; }

        [JsonIgnore]
        [Obsolete("// TODO: Create JSON Converter that will use Genres to fill data")]
        public virtual IEnumerable<int> GenreIds { get; set; }

        [JsonProperty("genres")]
        public virtual IEnumerable<Genre> Genres { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual IEnumerable<LanguageMinified> Languages { get; set; }

        [JsonProperty("production_companies")]
        public virtual IEnumerable<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public virtual IEnumerable<ProductionCountry> ProductionCountries { get; set; }
    }
}
