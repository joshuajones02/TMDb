using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class MovieVideoResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("results")]
        public IEnumerable<MovieVideoResult> Results { get; set; }
    }

    public partial class MovieVideoResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("iso_639_1")]
        public string Iso6391 { get; set; }

        [JsonProperty("iso_3166_1")]
        public string Iso31661 { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("site")]
        public string Site { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}