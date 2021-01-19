using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieVideosResult
    {
        [JsonProperty("size")]
        public virtual int Size { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("site")]
        public virtual string Site { get; set; }

        [JsonProperty("type")]
        public virtual string Type { get; set; }
    }
}