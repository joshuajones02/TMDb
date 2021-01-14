using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Models.Proxies.Collections
{
    public class CollectionRequest : TMDbRequest
    {
        [JsonIgnore]
        [Required]
        [StringFormatParameter("season_number")]
        public virtual int? SeasonNumber { get; set; }

        [JsonProperty("language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}