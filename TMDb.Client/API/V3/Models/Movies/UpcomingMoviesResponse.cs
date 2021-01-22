using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.Movies
{
    public class UpcomingMoviesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public List<MovieMinified> Results { get; set; }
    }
}