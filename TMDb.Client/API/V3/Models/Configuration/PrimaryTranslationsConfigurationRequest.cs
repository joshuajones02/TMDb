using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/primary_translations")]
    public class PrimaryTranslationsConfigurationRequest : TMDbRequest
    {
    }
}