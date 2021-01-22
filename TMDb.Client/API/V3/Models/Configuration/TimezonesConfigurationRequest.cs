using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/timezones")]
    public class TimezonesConfigurationRequest : TMDbRequest
    {
    }
}