using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Search;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class SearchProxy : ApiProxy
    {
        public SearchProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<MultiSearchResponse> GetAsync(MultiSearchRequest request) =>
            Client.SendAsync<MultiSearchResponse>(request);

        public virtual Task<SearchCollectionsResponse> GetAsync(SearchCollectionsRequest request) =>
            Client.SendAsync<SearchCollectionsResponse>(request);

        public virtual Task<SearchCompaniesResponse> GetAsync(SearchCompaniesRequest request) =>
            Client.SendAsync<SearchCompaniesResponse>(request);

        public virtual Task<SearchKeywordsResponse> GetAsync(SearchKeywordsRequest request) =>
            Client.SendAsync<SearchKeywordsResponse>(request);

        public virtual Task<SearchMoviesResponse> GetAsync(SearchMoviesRequest request) =>
            Client.SendAsync<SearchMoviesResponse>(request);

        public virtual Task<SearchPeopleResponse> GetAsync(SearchPeopleRequest request) =>
            Client.SendAsync<SearchPeopleResponse>(request);

        public virtual Task<SearchTVResponse> GetAsync(SearchTVRequest request) =>
            Client.SendAsync<SearchTVResponse>(request);
    }
}