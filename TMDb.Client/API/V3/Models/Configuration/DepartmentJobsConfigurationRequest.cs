using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Configuration
{
    [ApiGetEndpoint("/configuration/jobs")]
    public class DepartmentJobsConfigurationRequest : TMDbRequest
    {
    }
}