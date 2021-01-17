using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class DeleteSessionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "session_id")]
        public string SessionId { get; set; }
    }
}