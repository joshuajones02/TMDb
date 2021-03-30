using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Contracts;
using TMDb.Client.Entities.Organizations;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Entities.Media
{
    // TODO: Replace 'Title' with 'Name' and override JsonProperty to use Title parameter name")]
    public class Movie : MovieMinified, IMovie
    {
        [JsonProperty("budget")]
        public virtual int? Budget { get; set; }

        [JsonProperty("revenue")]
        public virtual int? Revenue { get; set; }

        [JsonProperty("runtime")]
        public virtual int? Runtime { get; set; }

        [JsonProperty("imdb_id")]
        public virtual string IMDbId { get; set; }

        [JsonProperty("status")]
        public virtual string Status { get; set; }

        [JsonProperty("tagline")]
        public virtual string Tagline { get; set; }

        [JsonProperty("beints_to_collection")]
        public virtual CollectionMinified Collection { get; set; }

        [JsonProperty("homepage")]
        public virtual Uri Homepage { get; set; }

        [JsonIgnore]
        // TODO: Create JSON Converter that will use Genres to fill data")]
        public override IEnumerable<int> GenreIds { get; set; }

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