using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Movie;
using TMDb.Client.API.V3.Models.TV;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class DiscoverProxy : ApiProxy
    {
        public DiscoverProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<DiscoverMovieResponse> Movies(DiscoverMovieRequest request) =>
            Client.GetAsync<DiscoverMovieResponse>(Serialize("/discover/movie", request));

        public virtual Task<DiscoverTVResponse> TV(DiscoverTVRequest request) =>
            Client.GetAsync<DiscoverTVResponse>(Serialize("/discover/tv", request));
    }
}