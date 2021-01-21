using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class ApiRequest
    {
        public ApiEndpoint Endpoint { get; set; }
        public List<ApiParameter> Parameters { get; set; }
    }
}