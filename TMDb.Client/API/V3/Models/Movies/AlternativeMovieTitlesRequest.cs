using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/alternative_titles")]
    public class AlternativeMovieTitlesRequest : MovieBaseRequest
    {
        [ApiParameter(
            Name = "country",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string CountryCode { get; set; }
    }
}