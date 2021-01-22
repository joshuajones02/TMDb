using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Authentication
{
    [ApiGetEndpoint("/authentication/guest_session/new")]
    public class CreateGuestSessionRequest : TMDbRequest
    {
    }
}