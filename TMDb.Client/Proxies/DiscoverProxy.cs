using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class DiscoverProxy : TMDbProxy
    {
        // TODO: Merge discovermovie and discovertv here

        public DiscoverProxy(TMDbClient client) : base(client)
        {
        }

        public Task<DiscoverMovieResponse> Movies(DiscoverMovieRequest request) =>
            Client.GetAsync<DiscoverMovieResponse>(Serialize("/discover/movie", request));

        public Task<DiscoverTVResponse> TV(DiscoverTVRequest request) =>
            Client.GetAsync<DiscoverTVResponse>(Serialize("/discover/tv", request));
    }
}