using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class DeleteSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.JsonBody)]
        public virtual string SessionId { get; set; }
    }
}