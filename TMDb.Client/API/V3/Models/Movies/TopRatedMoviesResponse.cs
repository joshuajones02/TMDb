using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class TopRatedMoviesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public List<MovieMinified> Results { get; set; }
    }
}
