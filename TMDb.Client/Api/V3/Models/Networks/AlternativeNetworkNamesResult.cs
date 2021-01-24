using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Networks
{
    public class AlternativeNetworkNamesResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}