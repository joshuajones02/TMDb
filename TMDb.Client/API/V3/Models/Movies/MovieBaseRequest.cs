using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Movies
{
    // TODO: Is this class really needed??
    public abstract class MovieBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "movie_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int MovieId { get; set; }
    }
}