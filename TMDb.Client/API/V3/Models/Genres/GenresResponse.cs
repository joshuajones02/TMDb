using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Genres
{
    public class GenresResponse
    {
        [JsonProperty("genres")]
        public IEnumerable<Genre> Genres { get; set; }
    }
}