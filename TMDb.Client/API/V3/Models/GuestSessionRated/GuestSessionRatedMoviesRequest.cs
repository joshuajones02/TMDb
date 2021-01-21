using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.GuestSessionRated
{
    [ApiGetEndpoint("/guest_session/{guest_session_id}/rated/movies")]
    public class GuestSessionRatedMoviesRequest : GuestSessionRatedRequest
    {
    }
}