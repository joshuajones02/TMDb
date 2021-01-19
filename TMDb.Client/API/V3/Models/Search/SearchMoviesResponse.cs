using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchMoviesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<MovieMinified> Results { get; set; }
    }
}