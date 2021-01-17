using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVVideoResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<TVVideoResult> Results { get; set; }
    }

    public class TVVideoResult
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("size")]
        public virtual int Size { get; set; }

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