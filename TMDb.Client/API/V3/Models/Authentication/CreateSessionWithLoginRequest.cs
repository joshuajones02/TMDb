using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateSessionWithLoginRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "username",
            ParameterType = ParameterType.JsonBody)]
        public virtual string Username { get; set; }

        [ApiParameter(
            Name = "password",
            ParameterType = ParameterType.JsonBody)]
        public virtual string Password { get; set; }

        [ApiParameter(
            Name = "request_token",
            ParameterType = ParameterType.JsonBody)]
        public virtual string RequestToken { get; set; }
    }
}