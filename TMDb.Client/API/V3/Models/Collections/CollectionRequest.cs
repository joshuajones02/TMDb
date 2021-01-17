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

        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}