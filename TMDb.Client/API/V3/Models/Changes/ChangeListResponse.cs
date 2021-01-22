using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Changes
{
    public class ChangeListResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual IEnumerable<ChangeItem> Changes { get; set; }
    }
}