using System;
using TMDb.Client.Attributes;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/account_states")]
    public class TVEpisodesAccountStatesRequest : TVEpisodesRequest, IGuestSession
    {
        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }
    }
}