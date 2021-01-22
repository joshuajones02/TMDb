using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/movie_credits")]
    public class PeopleMovieCreditsRequest : PeopleRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}