using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models
{
    public class TMDbStatusResponse : TMDbResponse
    {
        [JsonProperty("status_code")]
        public virtual int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public virtual string StatusMessage { get; set; }
    }
}