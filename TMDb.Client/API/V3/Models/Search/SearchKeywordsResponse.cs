using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchKeywordsResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Keyword> Keywords { get; set; }
    }
}