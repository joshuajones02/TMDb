using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/external_ids")]
    public class MovieExternalIdsRequest : MovieBaseRequest
    {
    }
}