using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Items;
using TMDb.Client.Entities.Places;

namespace TMDb.Client.Entities.Media
{
    // TODO: Replace "Title" with "Name" and override JsonProperty to use Title parameter name
    [Obsolete("// TODO: Review model's properties to ensure it has everything implemented - may have modifictations that were incorrect")]
    public class Movie : MovieMinified // : TMDbEntity
    {
        [JsonProperty("revenue")]
        public decimal? Revenue { get; set; }

        [JsonProperty("runtime")]
        public short? Runtime { get; set; }

        [JsonProperty("budget")]
        public decimal? Budget { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDbId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("belongs_to_collection")]
        public MinifiedCollection Collection { get; set; }

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