using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Search;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class SearchProxy : ApiProxy
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

        public virtual Task<MultiSearchResponse> SearchAsync(MultiSearchRequest request) =>
            Client.GetAsync<MultiSearchResponse>(
                ValidateThenSerailize("/search/multi", request));

        public virtual Task<SearchCollectionsResponse> SearchAsync(SearchCollectionsRequest request) =>
            Client.GetAsync<SearchCollectionsResponse>(
                ValidateThenSerailize("/search/collection", request));

        public virtual Task<SearchCompaniesResponse> SearchAsync(SearchCompaniesRequest request) =>
            Client.GetAsync<SearchCompaniesResponse>(
                ValidateThenSerailize("/search/company", request));

        public virtual Task<SearchKeywordsResponse> SearchAsync(SearchKeywordsRequest request) =>
            Client.GetAsync<SearchKeywordsResponse>(
                ValidateThenSerailize("/search/keyword", request));

        public virtual Task<SearchMoviesResponse> SearchAsync(SearchMoviesRequest request) =>
            Client.GetAsync<SearchMoviesResponse>(
                ValidateThenSerailize("/search/movie", request));

        public virtual Task<SearchPeopleResponse> SearchAsync(SearchPeopleRequest request) =>
            Client.GetAsync<SearchPeopleResponse>(
                ValidateThenSerailize("/search/person", request));

        public virtual Task<SearchTVResponse> SearchAsync(SearchTVRequest request) =>
            Client.GetAsync<SearchTVResponse>(
                ValidateThenSerailize("/search/tv", request));
    }
}