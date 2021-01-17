using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Keywords
{
    public class KeywordMovieResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<MovieMinified> Results { get; set; }
    }
}