using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class DiscoverTVProxy : TMDbProxy
    {
        public DiscoverTVProxy(TMDbClient client) : base(client) =>
            Path = "/discover/tv";

        protected string Path { get; }

        public Task<DiscoverTVResponse> Discover(DiscoverTVRequest request) =>
            Client.GetAsync<DiscoverTVResponse>(Serialize(Path, request));
    }
}