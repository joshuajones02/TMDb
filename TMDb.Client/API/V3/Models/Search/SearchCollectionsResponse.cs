using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchCollectionsResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<MinifiedCollection> Collections { get; set; }
    }
}