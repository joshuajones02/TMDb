using System.Collections.Generic;

namespace TMDb.Client.Models
{
    public class ApiParameter
    {
        public Dictionary<string, string> Headers { get; set; }
        public Dictionary<string, string> QueryParameters { get; set; }
        public Dictionary<string, string> PathParameters { get; set; }
        public Dictionary<string, string> JsonBody { get; set; }
        public string Version { get; set; }
    }
}