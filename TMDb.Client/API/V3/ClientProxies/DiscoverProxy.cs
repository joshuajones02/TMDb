using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Discover;
using TMDb.Client.API.V3.Models.TV;

namespace TMDb.Client.API.V3.ClientProxies
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