using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Entities.Things
{
    public class Collection : CollectionMinified
    {
        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("parts")]
        public IEnumerable<MovieMinified> Parts { get; set; }
    }
}