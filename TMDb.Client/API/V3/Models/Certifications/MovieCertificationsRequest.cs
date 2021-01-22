using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Certifications
{
    [ApiGetEndpoint("/certification/movie/list")]
    public class MovieCertificationsRequest : TMDbRequest
    {
    }
}