using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Discover
{
    public class DiscoverTVResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual List<TVMinified> Results { get; set; }
    }
}