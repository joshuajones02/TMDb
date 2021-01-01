using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class SearchTVProxy : TMDbProxy
    {
        public SearchTVProxy(TMDbClient client) : base(client) =>
            Path = "/search/tv";

        protected string Path { get; }

        public Task<SearchTVResponse> SearchAsync(int page, string query) =>
            Client.GetAsync<SearchTVResponse>(Serialize(Path, new SearchTVRequest(page, query)));
    }
}