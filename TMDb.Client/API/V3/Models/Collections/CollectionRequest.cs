using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Collections
{
    public abstract class CollectionRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "collection_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int CollectionId { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}