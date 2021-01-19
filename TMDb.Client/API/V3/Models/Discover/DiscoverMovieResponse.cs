using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Discover
{
    public class DiscoverMovieResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual List<MovieMinified> Results { get; set; }
    }
}
