using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Search
{
    public class MultiSearchResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<SearchResult> Results { get; set; }
    }
}