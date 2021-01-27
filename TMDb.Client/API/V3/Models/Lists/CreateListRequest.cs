using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Lists
{
    [ApiPostEndpoint("/list")]
    public class CreateListRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        //[ApiParameter(
        //    Name = "Content-Type",
        //    ParameterType = ParameterType.Header)]
        //public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "name",
            ParameterType = ParameterType.JsonBody)]
        public virtual string Name { get; set; }

        [ApiParameter(
            Name = "description",
            ParameterType = ParameterType.JsonBody)]
        public virtual string Description { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.JsonBody)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}