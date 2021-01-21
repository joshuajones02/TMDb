using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/languages")]
    public class LanguagesConfigurationRequest : TMDbRequest
    {
    }
}