using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class Language : LanguageMinified
    {
        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }
    }

    public class LanguageMinified
    {
        [JsonProperty("iso_639_1")]
        public virtual string Abbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}