using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Collections
{
    public class Translation
    {
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }

        [JsonProperty("data")]
        public virtual TranslationData Data { get; set; }
    }

    public class TranslationData
    {
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("homepage")]
        public virtual string Homepage { get; set; }
    }
}