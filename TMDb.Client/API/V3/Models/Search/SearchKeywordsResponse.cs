using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Items;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchKeywordsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Keyword> Keywords { get; set; }
    }
}