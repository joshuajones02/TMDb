using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieDetailsResponse : TMDb.Client.Entities.Media.Movie
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public double? VoteAverage { get; set; }

        [JsonProperty("budget")]
        public int? Budget { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("revenue")]
        public int? Revenue { get; set; }

        [JsonProperty("runtime")]
        public int? Runtime { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDbId { get; set; }

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }

        [JsonProperty("beints_to_collection")]
        public CollectionMinified Collection { get; set; }

        [JsonProperty("genres")]
        public IEnumerable<Genre> Genres { get; set; }

        [JsonProperty("spoken_languages")]
        public IEnumerable<LanguageMinified> Languages { get; set; }

        [JsonProperty("production_companies")]
        public IEnumerable<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public IEnumerable<ProductionCountry> ProductionCountries { get; set; }
    }

    //public partial class ProductionCountry
    //{
    //    [JsonProperty("iso_3166_1")]
    //    public string Iso3166_1 { get; set; }

    //    [JsonProperty("name")]
    //    public string Name { get; set; }
    //}
}
