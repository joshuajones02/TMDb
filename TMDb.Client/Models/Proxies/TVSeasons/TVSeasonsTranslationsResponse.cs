using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsTranslationsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("translations")]
        public virtual TVSeasonsTranslations[] Translations { get; set; }
    }

    public class TVSeasonsTranslations
    {
        [JsonProperty("iso_639_1")]
        public virtual string Language { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("english_name")]
        public virtual string EnglishName { get; set; }

        [JsonProperty("data")]
        public virtual TVSeasonsTranslationsData Data { get; set; }
    }

    public class TVSeasonsTranslationsData
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }
    }
}