using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVRecommendationsResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public IEnumerable<TVMinified> Results { get; set; }
    }
}