using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Entities.Media
{
    public class EpisodeGroup // : TMDbItem (*can't implement, Id is string here)
    {
        [JsonProperty("locked")]
        public virtual bool Locked { get; set; }

        [JsonProperty("order")]
        public virtual int Order { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("episodes")]
        public virtual IEnumerable<Episode> Episodes { get; set; }
    }
}