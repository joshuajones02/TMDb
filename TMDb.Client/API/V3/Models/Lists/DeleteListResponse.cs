using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class DeleteListResponse
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
    }
}