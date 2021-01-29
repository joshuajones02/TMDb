using System;
using TMDb.Client.Attributes;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/account_states")]
    public class TVSeasonsAccountStatesRequest : TVSeasonsRequest, ISession, IGuestSession
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