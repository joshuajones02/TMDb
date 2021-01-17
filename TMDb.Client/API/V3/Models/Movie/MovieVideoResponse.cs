using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class MovieVideoResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<MovieVideoResult> Results { get; set; }
    }

    public class MovieVideoResult
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("size")]
        public virtual int Size { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string Iso6391 { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string Iso31661 { get; set; }

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