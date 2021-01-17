using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class LanguagesResponse
    {
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("english_name")]
        public virtual string Language { get; set; }

        [JsonProperty("name")]
        public virtual string OriginalLanguage { get; set; }
    }
}