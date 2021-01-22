using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.Search
{
    public class SearchKeywordsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Keyword> Keywords { get; set; }
    }
}