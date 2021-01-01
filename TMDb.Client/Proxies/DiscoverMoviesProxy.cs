using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class DiscoverMoviesProxy : TMDbProxy
    {
        public DiscoverMoviesProxy(TMDbClient client) : base(client) =>
            Path = "/discover/movie";

        protected string Path { get; }

        public Task<DiscoverMovieResponse> Discover(DiscoverMovieRequest request) =>
            Client.GetAsync<DiscoverMovieResponse>(Serialize(Path, request));
    }
}