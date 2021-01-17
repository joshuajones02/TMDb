using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class CreateListResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("list_id")]
        public int ListId { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
    }
}