using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Entities
{
    public class MinifiedCollection
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }
    }

    public class Collection : MinifiedCollection
    {
        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("parts")]
        public IEnumerable<MovieMinified> Parts { get; set; }
    }
}