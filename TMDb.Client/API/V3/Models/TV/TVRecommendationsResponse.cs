using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVRecommendationsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public IEnumerable<TVMinified> Results { get; set; }
    }
}