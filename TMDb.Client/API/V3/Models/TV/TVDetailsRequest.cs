using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}")]
    public class TVDetailsRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Append requests within the same namespace to the response.
        ///     pattern: ([\w]+)
        /// </summary>
        [ApiParameter(
            Name = "append_to_response",
            ParameterType = ParameterType.Query)]
        public virtual string AppendToResponse { get; set; }
    }
}