using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    public class DepartmentJobsConfigurationResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<DepartmentModel> Departments { get; set; }
    }

    public class DepartmentModel
    {
        [JsonProperty("department")]
        public virtual string Department { get; set; }

        [JsonProperty("jobs")]
        public virtual string[] Jobs { get; set; }
    }
}