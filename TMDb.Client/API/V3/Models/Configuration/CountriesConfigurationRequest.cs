using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/countries")]
    public class CountriesConfigurationRequest : TMDbRequest
    {
    }
}