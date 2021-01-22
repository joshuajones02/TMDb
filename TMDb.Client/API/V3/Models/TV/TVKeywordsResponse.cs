using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVKeywordsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<Keyword> Results { get; set; }
    }
}