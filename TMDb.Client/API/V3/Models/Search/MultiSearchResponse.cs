using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Search
{
    public class MultiSearchResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public IEnumerable<MultiSearchResultUnion> Results { get; set; }
    }
}