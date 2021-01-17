using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "request_token",
            ParameterType = ParameterType.JsonBody)]
        public virtual string RequestToken { get; set; }
    }
}