using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class DepartmentJobsResponse
    {
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