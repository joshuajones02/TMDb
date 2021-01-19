using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class NowPlayingMoviesResponse : TMDbCollectionResponse
    {
        [JsonProperty("dates")]
        public virtual Dates Dates { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<MovieMinified> Results { get; set; }
    }

    public class Dates
    {
        [JsonProperty("maximum")]
        public virtual DateTime? Maximum { get; set; }

        [JsonProperty("minimum")]
        public virtual DateTime? Minimum { get; set; }
    }
}