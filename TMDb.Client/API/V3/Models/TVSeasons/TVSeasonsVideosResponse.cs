using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsVideosResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<TVSeasonsVideosResult> Videos { get; set; }
    }

    public class TVSeasonsVideosResult
    {
        [JsonProperty("size")]
        public virtual int Resolution { get; set; }

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

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("site")]
        public virtual VideoSource Site { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("type")]
        public virtual VideoType Type { get; set; }
    }
}