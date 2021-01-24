using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class ApiParameter
    {
        public ApiParameter()
        {
            Headers = new Dictionary<string, string>();
            QueryParameters = new Dictionary<string, string>();
            PathParameters = new Dictionary<string, string>();
            JsonBody = new Dictionary<string, string>();
        }

        public IDictionary<string, string> Headers { get; }
        public IDictionary<string, string> QueryParameters { get; }
        public IDictionary<string, string> PathParameters { get; }
        public IDictionary<string, string> JsonBody { get; }

        public string Version { get; set; }
    }
}