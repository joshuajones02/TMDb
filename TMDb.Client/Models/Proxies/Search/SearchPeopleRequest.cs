using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchPeopleRequest : SearchRequest
    {
        [JsonProperty("include_adult")]
        public virtual bool IncludeAdult { get; set; }

        [JsonProperty("language")]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        /// pattern: ^[A-Z]{2}$
        /// </summary>
        [JsonProperty("region")]
        public virtual string Region { get; set; }
    }
}