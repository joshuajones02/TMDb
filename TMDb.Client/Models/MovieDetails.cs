using TMDb.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Entities
{
    public class MovieDetails // TODO: Rename to movie?
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("popularity")]
        public decimal? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public decimal? VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int? VoteCount { get; set; }

        [JsonProperty("revenue")]
        public decimal? Revenue { get; set; }

        [JsonProperty("runtime")]
        public short? Runtime { get; set; }

        [JsonProperty("budget")]
        public decimal? Budget { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDbId { get; set; }

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

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        // 
        // START:
        //      Table References 

        //public int? CollectionId { get; set; }

        [JsonProperty("belongs_to_collection")]
        public Collection Collection { get; set; }

        [JsonProperty("genres")]
        public virtual IEnumerable<Genre> Genres { get; set; }

        [JsonProperty("spoken_languages")]
        public virtual IEnumerable<Language> Languages { get; set; }
        
        //[JsonProperty("genres")]
        //public virtual ICollection<Genre> Genres { get; set; }
        //public List<MovieGenres> MovieGenres { get; set; }

        //[JsonProperty("spoken_languages")]
        //public virtual ICollection<Language> SpokenLanguages { get; set; }
        //public List<MovieLanguage> MovieLanguage { get; set; }

        //[JsonProperty("production_companies")]
        //public ICollection<ProductionCompany> ProductionCompanies { get; set; }

        //[JsonProperty("production_countries")]
        //public ICollection<ProductionCountry> ProductionCountries { get; set; }

    }
}