using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    [ApiGetEndpoint("/guest_session/{guest_session_id}/rated/tv")]
    public class GuestSessionRatedTVRequest : GuestSessionRatedRequest
    {
    }
}