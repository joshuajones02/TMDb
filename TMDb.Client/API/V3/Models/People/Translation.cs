using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.People
{
    public class Translation
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("data")]
        public virtual Data Data { get; set; }
    }
}