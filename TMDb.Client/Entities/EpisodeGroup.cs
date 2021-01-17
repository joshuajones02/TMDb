using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Entities
{
    public class EpisodeGroup
    {
        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("episodes")]
        public IEnumerable<Episode> Episodes { get; set; }
    }
}
