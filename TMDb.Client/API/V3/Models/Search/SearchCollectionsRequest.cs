using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    [ApiGetEndpoint("/search/collection")]
    public class SearchCollectionsRequest : SearchRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}