using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class TVListRequest : TMDbRequest
    {
        public TVListRequest()
        {
        }

        public TVListRequest(int page) =>
            Page = page;

        [JsonProperty("page")]
        [JsonRequired]
        public int Page { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}