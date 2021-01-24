using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Keywords
{
    [ApiGetEndpoint("/keyword/{keyword_id}/movies")]
    public class KeywordMovieRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "include_adult",
            ParameterType = ParameterType.Query)]
        public virtual bool? IsAdult { get; set; }

        [ApiParameter(
            Name = "keyword_id",
            ParameterType = ParameterType.Query)]
        [Range(1, int.MaxValue)]
        [Required]
        public virtual int KeywordId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}