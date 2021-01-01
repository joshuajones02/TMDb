using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class LatestTVProxy : TMDbProxy
    {
        public LatestTVProxy(TMDbClient client) : base(client) =>
            Path = "/tv/latest";

        protected string Path { get; }

        public Task<LatestTVResponse> GetAsync() =>
            Client.GetAsync<LatestTVResponse>(Serialize(Path, new LatestTVRequest()));
    }
}