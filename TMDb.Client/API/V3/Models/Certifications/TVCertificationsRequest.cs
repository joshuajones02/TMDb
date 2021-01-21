using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Certifications
{
    [ApiGetEndpoint("/certification/tv/list")]
    public class TVCertificationsRequest : TMDbRequest
    {
    }
}