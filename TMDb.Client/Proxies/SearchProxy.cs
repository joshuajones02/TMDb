using System;
using System.Threading.Tasks;
using TMDb.Client.Models.Proxies.Search;

namespace TMDb.Client.Proxies
{
    internal class SearchProxy : ProxyBase
    {
        public SearchProxy(TMDbClient client) : base(client)
        {
        }

        private Uri ValidateThenSerailize(string path, SearchRequest request)
        {
            if (request.Query.IsNullOrEmpty())
                throw new ArgumentNullException(nameof(request.Query));

            return Serialize(path, request);
        }

        public Task<MultiSearchResponse> SearchAsync(MultiSearchRequest request) =>
            Client.GetAsync<MultiSearchResponse>(
                ValidateThenSerailize("/search/multi", request));

        public Task<SearchCollectionsResponse> SearchAsync(SearchCollectionsRequest request) =>
            Client.GetAsync<SearchCollectionsResponse>(
                ValidateThenSerailize("/search/collection", request));

        public Task<SearchCompaniesResponse> SearchAsync(SearchCompaniesRequest request) =>
            Client.GetAsync<SearchCompaniesResponse>(
                ValidateThenSerailize("/search/company", request));

        public Task<SearchKeywordsResponse> SearchAsync(SearchKeywordsRequest request) =>
            Client.GetAsync<SearchKeywordsResponse>(
                ValidateThenSerailize("/search/keyword", request));

        public Task<SearchMoviesResponse> SearchAsync(SearchMoviesRequest request) =>
            Client.GetAsync<SearchMoviesResponse>(
                ValidateThenSerailize("/search/movie", request));

        public Task<SearchPeopleResponse> SearchAsync(SearchPeopleRequest request) =>
            Client.GetAsync<SearchPeopleResponse>(
                ValidateThenSerailize("/search/person", request));

        public Task<SearchTVResponse> SearchAsync(SearchTVRequest request) =>
            Client.GetAsync<SearchTVResponse>(
                ValidateThenSerailize("/search/tv", request));
    }
}