using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}/aggregate_credits")]
    public class TVAggregateCreditsRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}