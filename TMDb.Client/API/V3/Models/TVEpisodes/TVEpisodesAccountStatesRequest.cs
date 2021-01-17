using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesAccountStatesRequest : TVEpisodesRequest
    {
        [ApiParameter(
            Name = "guest_session_id")]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id")]
        public virtual string SessionId { get; set; }
    }
}