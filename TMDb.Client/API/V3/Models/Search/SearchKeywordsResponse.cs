using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchKeywordsResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<Keyword> Keywords { get; set; }
    }
}