using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieVideosResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual List<MovieVideosResult> Results { get; set; }
    }
}
