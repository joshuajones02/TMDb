using TMDb.Client.Models;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class SearchMoviesProxy : TMDbProxy
    {
        public SearchMoviesProxy(TMDbClient client) : base(client) =>
            Path = "/search/movie";

        protected string Path { get; }

        public Task<SearchMoviesResponse> SearchAsync(int page, string query) =>
            Client.GetAsync<SearchMoviesResponse>(Serialize(Path, new SearchMoviesRequest(page, query)));

        public Task<SearchMoviesResponse> SearchKeywordsAsync(int page, string keywords) =>
            Client.GetAsync<SearchMoviesResponse>(Serialize(Path, new SearchMoviesRequest(page, keywords)));
    }
}