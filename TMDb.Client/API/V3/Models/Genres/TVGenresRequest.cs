using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Genres
{
    [ApiGetEndpoint("/genre/tv/list")]
    public class TVGenresRequest : TMDbRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}