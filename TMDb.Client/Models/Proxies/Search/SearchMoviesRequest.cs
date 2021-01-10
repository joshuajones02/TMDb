using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchMoviesRequest : SearchRequest
    {
        [JsonProperty("include_adult")]
        public bool IncludeAdult { get; set; }

        [JsonProperty("primary_release_year")]
        public int PrimaryReleaseYear { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        /// pattern: ^[A-Z]{2}$
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}