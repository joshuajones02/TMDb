using Newtonsoft.Json;

namespace TMDb.Client.API.V4.Models.Authentication
{
    public class CreateSessionResponse
    {
        [JsonProperty("success")]
        public virtual bool Success { get; set; }

        [JsonProperty("session_id")]
        public virtual string SessionId { get; set; }
    }
}