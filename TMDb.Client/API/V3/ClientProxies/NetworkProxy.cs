using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Networks;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class NetworkProxy : ApiProxy
    {
        public NetworkProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<NetworkDetailsResponse> GetAsync(NetworkDetailsRequest request) =>
            Client.SendAsync<NetworkDetailsResponse>(request);

        public virtual Task<AlternativeNetworkNamesResponse> GetAsync(AlternativeNetworkNamesRequest request) =>
            Client.SendAsync<AlternativeNetworkNamesResponse>(request);

        public virtual Task<NetworkImagesResponse> GetAsync(NetworkImagesRequest request) =>
            Client.SendAsync<NetworkImagesResponse>(request);
    }
}