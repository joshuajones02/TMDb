using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchCollectionsRequest : SearchRequest
    {
        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}