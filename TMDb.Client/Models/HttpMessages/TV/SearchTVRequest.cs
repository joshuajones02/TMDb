using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class SearchTVRequest : TMDbRequest
    {
        public SearchTVRequest(int page, string query)
        {
            Page = page;
            Query = query;
        }

        [JsonProperty("include_adult")]
        public bool IncludeAdult { get; set; }

        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }

        [JsonProperty("first_air_date_year")]
        public int FirstAirDateYear { get; set; }

        [JsonProperty("query")]
        [JsonRequired]
        public string Query { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}