using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class LanguagesResponse
    {
        [JsonProperty("iso_639_1")]
        public string Abbreviation { get; set; }

        [JsonProperty("english_name")]
        public string Language { get; set; }

        [JsonProperty("name")]
        public string OriginalLanguage { get; set; }
    }
}