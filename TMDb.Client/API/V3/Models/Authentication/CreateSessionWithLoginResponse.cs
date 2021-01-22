using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Authentication
{
    public class CreateSessionWithLoginResponse : AuthenticationResponse
    {
        [JsonProperty("request_token")]
        public virtual string RequestToken { get; set; }
    }
}