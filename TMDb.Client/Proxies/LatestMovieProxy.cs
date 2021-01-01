using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class LatestMovieProxy : TMDbProxy
    {
        public LatestMovieProxy(TMDbClient client) : base(client) =>
            Path = "/movie/latest";

        protected string Path { get; }

        public Task<LatestMovieResponse> GetAsync() =>
            Client.GetAsync<LatestMovieResponse>(Serialize(Path, new LatestMovieRequest()));
    }
}