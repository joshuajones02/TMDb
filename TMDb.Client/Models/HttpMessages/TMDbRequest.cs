using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class TMDbRequest
    {
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
    }
}