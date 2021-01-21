using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}/account_states")]
    public class TVAccountStatesRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Refactor all LanguageAbbreviations in requests to support 5 character code")]
        public virtual string LanguageAbbreviation { get; set; }

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