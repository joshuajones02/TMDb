using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities;

namespace TMDb.Client.API.V3.Models.Keywords
{
    public class KeywordMovieResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<MovieMinified> Results { get; set; }
    }
}