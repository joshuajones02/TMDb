using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Authentication
{
    [ApiDeleteEndpoint("/authentication/session")]
    public class DeleteSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.JsonBody)]
        public virtual string SessionId { get; set; }
    }
}