using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.HttpMessages.Genres
{
    public class GenresResponse
    {
        [JsonProperty("genres")]
        public IEnumerable<Genre> Genres { get; set; }
    }
}
