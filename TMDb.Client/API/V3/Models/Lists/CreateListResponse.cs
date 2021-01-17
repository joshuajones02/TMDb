using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class CreateListResponse
    {
        [JsonProperty("success")]
        public virtual bool Success { get; set; }

        [JsonProperty("status_code")]
        public virtual int StatusCode { get; set; }

        [JsonProperty("list_id")]
        public virtual int ListId { get; set; }

        [JsonProperty("status_message")]
        public virtual string StatusMessage { get; set; }
    }
}