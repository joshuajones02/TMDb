using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/account_states")]
    public class TVEpisodesAccountStatesRequest : TVEpisodesRequest
    {
        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query)]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }
    }
}