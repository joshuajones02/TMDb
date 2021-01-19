using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    public abstract class MovieBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "movie_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int MovieId { get; set; }
    }
}