using System.Linq;
using TMDb.Client.Api;
using TMDb.Client.Attributes;
using TMDb.Client.Models;

namespace TMDb.Client.Extensions
{
    public static class RequestBaseExtensions
    {
        public static ApiEndpoint GetApiEndpoint(this RequestBase request)
        {
            var endpoint = request.GetType()
                .GetCustomAttributes(inherit: true)
                .Single(x => x.GetType().IsAssignableFrom(typeof(ApiEndpointAttribute))
                          || x.GetType().IsSubclassOf(typeof(ApiEndpointAttribute)))
                .CastType<ApiEndpointAttribute>();

            return new ApiEndpoint
            {
                Path = endpoint.Path,
                HttpMethod = endpoint.HttpMethod
            };
        }
    }
}