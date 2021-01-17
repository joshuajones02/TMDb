using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateSessionWithLoginRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "username")]
        public string Username { get; set; }

        [ApiParameter(
            Name = "password")]
        public string Password { get; set; }

        [ApiParameter(
            Name = "request_token")]
        public string RequestToken { get; set; }
    }
}