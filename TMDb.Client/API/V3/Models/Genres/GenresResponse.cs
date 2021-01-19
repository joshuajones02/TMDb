using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.Genres
{
    public class GenresResponse
    {
        [JsonProperty("genres")]
        public virtual IEnumerable<Genre> Genres { get; set; }
    }
}