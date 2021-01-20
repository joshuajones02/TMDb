using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiGetEndpoint("/list/{list_id}")]
    [Obsolete("// TODO: Move value to appsettings file")]
    public class ListDetailsRequest : ListRequestBase
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}