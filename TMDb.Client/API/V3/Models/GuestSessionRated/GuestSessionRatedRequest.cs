using System;
using TMDb.Client.Attributes;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.GuestSessionRated
{
    public abstract class GuestSessionRatedRequest : TMDbRequest, IGuestSession
    {
        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Path,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "sort_by",
            ParameterType = ParameterType.Query)]
        public virtual GuestSessionRatingSortyBy SortBy { get; set; }
    }
}