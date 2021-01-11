using System.Threading.Tasks;
using TMDb.Client.Models;

namespace TMDb.Client.Proxies
{
    public class DiscoverProxy : ProxyBase
    {
        public DiscoverProxy(TMDbClient client) : base(client)
        {
        }

        public Task<DiscoverMovieResponse> Movies(DiscoverMovieRequest request) =>
            Client.GetAsync<DiscoverMovieResponse>(Serialize("/discover/movie", request));

        public Task<DiscoverTVResponse> TV(DiscoverTVRequest request) =>
            Client.GetAsync<DiscoverTVResponse>(Serialize("/discover/tv", request));
    }
}