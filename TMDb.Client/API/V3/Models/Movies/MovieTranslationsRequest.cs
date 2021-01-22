using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Movies
{
    /// <summary>
    /// Get a list of translations that have been created for a movie.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/translations")]
    public class MovieTranslationsRequest : MovieBaseRequest
    {
    }
}