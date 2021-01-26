using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/tagged_images")]
    public class PeopleTaggedImagesRequest : PeopleBaseRequest
    {
        public PeopleTaggedImagesRequest()
        {
            Page = 1;
        }

        [ApiParameter(
                Name = "page",
                ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual int Page { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}