using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVSeasons;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class TVSeasonsProxy : ApiProxy
    {
        public TVSeasonsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<TVSeasonsDetailsResponse> GetAsync(TVSeasonsDetailsRequest request) =>
            Client.SendAsync<TVSeasonsDetailsResponse>(request);

        public virtual Task<TVSeasonsAccountStatesResponse> GetAsync(TVSeasonsAccountStatesRequest request) =>
            Client.SendAsync<TVSeasonsAccountStatesResponse>(request);

        public virtual Task<TVSeasonsAggregateCreditsResponse> GetAsync(TVSeasonsAggregateCreditsRequest request) =>
            Client.SendAsync<TVSeasonsAggregateCreditsResponse>(request);

        public virtual Task<TVSeasonsChangesResponse> GetAsync(TVSeasonsChangesRequest request) =>
            Client.SendAsync<TVSeasonsChangesResponse>(request);

        public virtual Task<TVSeasonsCreditsResponse> GetAsync(TVSeasonsCreditsRequest request) =>
            Client.SendAsync<TVSeasonsCreditsResponse>(request);

        public virtual Task<TVSeasonsExternalIdsResponse> GetAsync(TVSeasonsExternalIdsRequest request) =>
            Client.SendAsync<TVSeasonsExternalIdsResponse>(request);

        public virtual Task<TVSeasonsImagesResponse> GetAsync(TVSeasonsImagesRequest request) =>
            Client.SendAsync<TVSeasonsImagesResponse>(request);

        public virtual Task<TVSeasonsTranslationsResponse> GetAsync(TVSeasonsTranslationsRequest request) =>
            Client.SendAsync<TVSeasonsTranslationsResponse>(request);

        public virtual Task<TVSeasonsVideosResponse> GetAsync(TVSeasonsVideosRequest request) =>
            Client.SendAsync<TVSeasonsVideosResponse>(request);
    }
}