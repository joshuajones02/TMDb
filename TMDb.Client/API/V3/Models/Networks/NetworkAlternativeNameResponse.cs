using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Networks
{
    public class NetworkAlternativeNameResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("results")]
        public IEnumerable<NetworkAlternativeNameResult> Results { get; set; }
    }
}