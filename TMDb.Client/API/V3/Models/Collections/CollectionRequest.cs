using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Collections
{
    public class CollectionRequest : TMDbRequest
    {
        [JsonIgnore]
        [Required]
        [StringFormatParameter("season_number")]
        public virtual int? SeasonNumber { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}