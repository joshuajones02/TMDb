using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Networks;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class NetworkProxy : ApiProxy
    {
        public NetworkProxy(TMDbClient client) : base(client)
        {
        }

        public virtual string FormatPath(string path, int id) =>
            string.Format(path, id);

        public virtual Task<NetworkDetailsResponse> GetAsync(NetworkDetailsRequest request) =>
            Client.GetAsync<NetworkDetailsResponse>(
                Serialize(FormatPath("/network/{0}", request.NetworkId), request));

        public virtual Task<NetworkAlternativeNameResponse> GetAsync(NetworkAlternativeNameRequest request) =>
            Client.GetAsync<NetworkAlternativeNameResponse>(
                Serialize(FormatPath("/network/{0}", request.NetworkId), request));

        public virtual Task<NetworkImagesResponse> GetAsync(NetworkImagesRequest request) =>
            Client.GetAsync<NetworkImagesResponse>(
                Serialize(FormatPath("/network/{0}/images", request.NetworkId), request));
    }
}