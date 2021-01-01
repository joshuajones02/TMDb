using Newtonsoft.Json;

namespace TMDb.Client.Entities
{
    public class Language
    {
        [JsonProperty("iso_639_1")]
        public string Abbreviation { get; set; }

        [JsonProperty("english_name")]
        public string EnglishName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}