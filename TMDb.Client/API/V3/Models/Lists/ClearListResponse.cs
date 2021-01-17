using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class ClearListResponse
    {
        [JsonProperty("status_code")]
        public virtual int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public virtual string StatusMessage { get; set; }
    }
}