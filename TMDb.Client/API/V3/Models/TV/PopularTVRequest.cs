using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    [ApiGetEndpoint("/tv/popular")]
    public class PopularTVRequest : TVBaseRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify which page to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Required]
        [Obsolete("// TODO: Handle default value (1)")]
        public virtual int Page { get; set; }
    }
}