using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Keywords
{
    [ApiGetEndpoint("/keyword/{keyword_id}")]
    public class KeywordDetailsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "keyword_id",
            ParameterType = ParameterType.Query)]
        [Range(1, int.MaxValue)]
        [Required]
        public virtual int KeywordId { get; set; }
    }
}