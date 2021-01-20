using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Contracts;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieDetailsResponse : TMDb.Client.Entities.Media.Movie, IMovie
    {
        [JsonProperty("adult")]
        public override bool Adult { get; set; }

        [JsonProperty("video")]
        public override bool Video { get; set; }

        [JsonProperty("popularity")]
        public override double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public override double? VoteAverage { get; set; }

        [JsonProperty("budget")]
        public override int? Budget { get; set; }

        [JsonProperty("id")]
        public override int Id { get; set; }

        [JsonProperty("revenue")]
        public override int? Revenue { get; set; }

        [JsonProperty("runtime")]
        public override int? Runtime { get; set; }

        [JsonProperty("vote_count")]
        public override int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public override string BackdropPath { get; set; }

        [JsonProperty("imdb_id")]
        public override string IMDbId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("original_language")]
        public override string LanguageAbbreviation { get; set; }

        [JsonProperty("original_title")]
        public override string OriginalTitle { get; set; }

        [JsonProperty("overview")]
        public override string Overview { get; set; }

        [JsonProperty("poster_path")]
        public override string PosterPath { get; set; }

        [JsonProperty("status")]
        public override string Status { get; set; }

        [JsonProperty("tagline")]
        public override string Tagline { get; set; }

        [JsonProperty("title")]
        public override string Title { get; set; }

        [JsonProperty("release_date")]
        public override DateTime? ReleaseDate { get; set; }

        [JsonProperty("homepage")]
        public override Uri Homepage { get; set; }

        [JsonProperty("beints_to_collection")]
        public override CollectionMinified Collection { get; set; }

        [JsonProperty("genres")]
        public override IEnumerable<Genre> Genres { get; set; }

        [JsonProperty("spoken_languages")]
        public override IEnumerable<LanguageMinified> Languages { get; set; }

        [JsonProperty("production_companies")]
        public override IEnumerable<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public override IEnumerable<ProductionCountry> ProductionCountries { get; set; }
    }

    //public override partial class ProductionCountry
    //{
    //    [JsonProperty("iso_3166_1")]
    //    public override string Iso3166_1 { get; set; }

    //    [JsonProperty("name")]
    //    public override string Name { get; set; }
    //}
}