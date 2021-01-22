using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration")]
    public class ConfigurationRequest : TMDbRequest
    {
    }
}