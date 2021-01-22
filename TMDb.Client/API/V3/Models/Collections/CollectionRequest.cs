using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Collections
{
    public abstract class CollectionRequest : TMDbRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}