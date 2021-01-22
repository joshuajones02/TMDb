using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/jobs")]
    public class DepartmentJobsConfigurationRequest : TMDbRequest
    {
    }
}