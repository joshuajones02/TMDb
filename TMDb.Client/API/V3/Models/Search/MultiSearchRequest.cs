using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Search
{
    public class MultiSearchRequest : SearchRequest
    {
        [ApiParameter(
            Name = "include_adult")]
        public bool IncludeAdult { get; set; }

        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        /// pattern: ^[A-Z]{2}$
        /// </summary>
        [ApiParameter(
            Name = "region")]
        public string Region { get; set; }
    }
}