using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Configuration
{
    public class DepartmentJobsResponse
    {
        public IEnumerable<DepartmentModel> Departments { get; set; }
    }

    public class DepartmentModel
    {
        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("jobs")]
        public string[] Jobs { get; set; }
    }
}