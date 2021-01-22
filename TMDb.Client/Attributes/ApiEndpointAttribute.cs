using System;
using System.Net.Http;

namespace TMDb.Client.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class ApiEndpointAttribute : Attribute
    {
        public ApiEndpointAttribute(HttpMethod method, string path)
        {
            Path = path;
            HttpMethod = method;
        }

        public string Path { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }

    public class ApiDeleteEndpointAttribute : ApiEndpointAttribute
    {
        public ApiDeleteEndpointAttribute(string endpointPath) : base(HttpMethod.Delete, endpointPath)
        {
        }
    }

    public class ApiGetEndpointAttribute : ApiEndpointAttribute
    {
        public ApiGetEndpointAttribute(string endpointPath) : base(HttpMethod.Get, endpointPath)
        {
        }
    }

    public class ApiPostEndpointAttribute : ApiEndpointAttribute
    {
        public ApiPostEndpointAttribute(string endpointPath) : base(HttpMethod.Post, endpointPath)
        {
        }
    }

    public class ApiPutEndpointAttribute : ApiEndpointAttribute
    {
        public ApiPutEndpointAttribute(string endpointPath) : base(HttpMethod.Put, endpointPath)
        {
        }
    }
}