using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Entities.Items
{

    public class Collection : MinifiedCollection
    {
        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("parts")]
        public IEnumerable<MovieMinified> Parts { get; set; }
    }
}