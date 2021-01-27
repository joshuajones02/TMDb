using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Lists
{
    [ApiPostEndpoint("/list/{list_id}/add_item")]
    public class ListAddMovieRequest : ListRequestBase
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
            Name = "media_id",
            ParameterType = ParameterType.JsonBody)]
        [Obsolete("// TODO: Validation needed, value must be 1 or more")]
        public virtual int MediaId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.JsonBody)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}