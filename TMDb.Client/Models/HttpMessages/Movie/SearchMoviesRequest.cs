using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class SearchMoviesRequest : TMDbRequest
    {
        public SearchMoviesRequest(int page, string query)
        {
            Page = page;
            Query = query;
        }

        [JsonProperty("include_adult")]
        public bool IncludeAdult { get; set; }

        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }

        [JsonProperty("primary_release_year")]
        public int PrimaryReleaseYear { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("query")]
        [JsonRequired]
        public string Query { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}