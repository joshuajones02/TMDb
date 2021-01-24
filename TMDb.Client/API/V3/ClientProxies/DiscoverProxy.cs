using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Discover;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class DiscoverProxy : ApiProxy
    {
        public DiscoverProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<DiscoverMovieResponse> GetAsync(DiscoverMovieRequest request) =>
            Client.SendAsync<DiscoverMovieResponse>(request);

        public virtual Task<DiscoverTVResponse> GetAsync(DiscoverTVRequest request) =>
            Client.SendAsync<DiscoverTVResponse>(request);
    }
}