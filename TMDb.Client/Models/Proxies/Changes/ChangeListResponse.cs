using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Changes
{
    public class ChangeListResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual IEnumerable<ChangeItem> Changes { get; set; }
    }
}