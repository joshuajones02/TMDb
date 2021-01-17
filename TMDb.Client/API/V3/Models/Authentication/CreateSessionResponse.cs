using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateSessionResponse : TMDbResponse
    {
        [JsonProperty("success")]
        public virtual bool IsSuccess { get; set; }

        [JsonProperty("session_id")]
        public virtual string SessionId { get; set; }
    }
}