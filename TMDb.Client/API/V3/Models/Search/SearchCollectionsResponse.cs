using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Items;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchCollectionsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<MinifiedCollection> Collections { get; set; }
    }
}