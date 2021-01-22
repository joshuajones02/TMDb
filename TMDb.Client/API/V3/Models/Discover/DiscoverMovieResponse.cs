using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.Discover
{
    public class DiscoverMovieResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual List<MovieMinified> Results { get; set; }
    }
}