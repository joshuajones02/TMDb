using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    [ApiGetEndpoint("/tv/latest")]
    public class LatestTVRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}