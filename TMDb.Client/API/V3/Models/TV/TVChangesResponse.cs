using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVChangesResponse : TMDbResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<TVChangesResult> Changes { get; set; }
    }
}