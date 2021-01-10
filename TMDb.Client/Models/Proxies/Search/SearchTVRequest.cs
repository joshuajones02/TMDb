using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchTVRequest : SearchRequest
    {
        [JsonProperty("include_adult")]
        public bool IncludeAdult { get; set; }

        [JsonProperty("first_air_date_year")]
        public int FirstAirDateYear { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}