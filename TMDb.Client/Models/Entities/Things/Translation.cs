using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class Translation
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }

        [JsonProperty("data")]
        public virtual TranslationDataItem Data { get; set; }
    }
}