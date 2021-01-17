using Newtonsoft.Json;

namespace TMDb.Client.Entities.Places
{
    public class Language
    {
        [JsonProperty("iso_639_1")]
        public virtual string Abbreviation { get; set; }

        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}