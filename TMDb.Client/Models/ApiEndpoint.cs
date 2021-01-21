using System.Net.Http;

namespace TMDb.Client.Models
{
    public class ApiEndpoint
    {
        public string Path { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}