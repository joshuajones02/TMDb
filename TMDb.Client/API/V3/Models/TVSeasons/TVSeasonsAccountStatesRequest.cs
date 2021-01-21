using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/account_states")]
    public class TVSeasonsAccountStatesRequest : TVSeasonsRequest
    {
        [ApiParameter(
            Name = "guest_session_id")]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id")]
        public virtual string SessionId { get; set; }
    }
}