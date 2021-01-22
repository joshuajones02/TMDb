using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TV;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class TVProxy : ApiProxy
    {
        public TVProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<TVDetailsResponse> GetAsync(TVDetailsRequest request) =>
            Client.SendAsync<TVDetailsResponse>(request);

        public virtual Task<TVAccountStatesResponse> GetAsync(TVAccountStatesRequest request) =>
            Client.SendAsync<TVAccountStatesResponse>(request);

        public virtual Task<TVAggregateCreditsResponse> GetAsync(TVAggregateCreditsRequest request) =>
            Client.SendAsync<TVAggregateCreditsResponse>(request);

        public virtual Task<AlternativeTVTitlesResponse> GetAsync(AlternativeTVTitlesRequest request) =>
            Client.SendAsync<AlternativeTVTitlesResponse>(request);

        public virtual Task<TVChangesResponse> GetAsync(TVChangesRequest request) =>
            Client.SendAsync<TVChangesResponse>(request);

        public virtual Task<TVContentRatingsResponse> GetAsync(TVContentRatingsRequest request) =>
            Client.SendAsync<TVContentRatingsResponse>(request);

        public virtual Task<TVCreditsResponse> GetAsync(TVCreditsRequest request) =>
            Client.SendAsync<TVCreditsResponse>(request);
        
        public virtual Task<TVEpisodeGroupsResponse> GetAsync(TVEpisodeGroupsRequest request) =>
            Client.SendAsync<TVEpisodeGroupsResponse>(request);

        public virtual Task<TVExternalIdsResponse> GetAsync(TVExternalIdsRequest request) =>
            Client.SendAsync<TVExternalIdsResponse>(request);
        
        public virtual Task<TVImagesResponse> GetAsync(TVImagesRequest request) =>
            Client.SendAsync<TVImagesResponse>(request);
        
        public virtual Task<TVKeywordsResponse> GetAsync(TVKeywordsRequest request) =>
            Client.SendAsync<TVKeywordsResponse>(request);
        
        public virtual Task<TVRecommendationsResponse> GetAsync(TVRecommendationsRequest request) =>
            Client.SendAsync<TVRecommendationsResponse>(request);
        
        public virtual Task<TVReviewsResponse> GetAsync(TVReviewsRequest request) =>
            Client.SendAsync<TVReviewsResponse>(request);
        
        public virtual Task<TVScreenedTheatricallyResponse> GetAsync(TVScreenedTheatricallyRequest request) =>
            Client.SendAsync<TVScreenedTheatricallyResponse>(request);
        
        public virtual Task<SimilarTVResponse> GetAsync(SimilarTVRequest request) =>
            Client.SendAsync<SimilarTVResponse>(request);
        
        public virtual Task<TVTranslationsResponse> GetAsync(TVTranslationsRequest request) =>
            Client.SendAsync<TVTranslationsResponse>(request);
        
        public virtual Task<TVVideosResponse> GetAsync(TVVideosRequest request) =>
            Client.SendAsync<TVVideosResponse>(request);
        
        public virtual Task<TVWatchProvidersResponse> GetAsync(TVWatchProvidersRequest request) =>
            Client.SendAsync<TVWatchProvidersResponse>(request);
        
        public virtual Task<RateTVResponse> PostAsync(RateTVRequest request) =>
            Client.SendAsync<RateTVResponse>(request);
        
        public virtual Task<DeleteTVRatingResponse> DeleteAsync(DeleteTVRatingRequest request) =>
            Client.SendAsync<DeleteTVRatingResponse>(request);

        public virtual Task<LatestTVResponse> GetAsync(LatestTVRequest request) =>
            Client.SendAsync<LatestTVResponse>(request);

        public virtual Task<TVAiringTodayResponse> GetAsync(TVAiringTodayRequest request) =>
            Client.SendAsync<TVAiringTodayResponse>(request);

        public virtual Task<TVOnTheAirResponse> GetAsync(TVOnTheAirRequest request) =>
            Client.SendAsync<TVOnTheAirResponse>(request);

        public virtual Task<PopularTVResponse> GetAsync(PopularTVRequest request) =>
            Client.SendAsync<PopularTVResponse>(request);

        public virtual Task<TopRatedTVResponse> GetAsync(TopRatedTVRequest request) =>
            Client.SendAsync<TopRatedTVResponse>(request);
    }
}