using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/countries")]
    public class CountriesConfigurationRequest : TMDbRequest
    {
    }
}