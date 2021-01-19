using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.TV;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class TVProxy : ApiProxy
    {
        public TVProxy(TMDbClient client) : base(client)
        {
        }

        private string FormatPath(string path, int TVId) =>
            string.Format(path, TVId);

        public Task<TVDetailsResponse> GetAsync(TVDetailsRequest request) =>
            Client.GetAsync<TVDetailsResponse>(
                Serialize(FormatPath("/tv/{0}", request.TVId), request));

        public Task<TVAccountStatesResponse> GetAsync(TVAccountStatesRequest request) =>
            Client.GetAsync<TVAccountStatesResponse>(
                Serialize(FormatPath("/tv/{0}/account_states", request.TVId), request));
        
        public Task<TVAggregateCreditsResponse> GetAsync(TVAggregateCreditsRequest request) =>
            Client.GetAsync<TVAggregateCreditsResponse>(
                Serialize(FormatPath("/tv/{tv_id}/aggregate_credits", request.TVId), request));

        public Task<AlternativeTVTitlesResponse> GetAsync(AlternativeTVTitlesRequest request) =>
            Client.GetAsync<AlternativeTVTitlesResponse>(
                Serialize(FormatPath("/tv/{0}/alternative_titles", request.TVId), request));

        public Task<TVChangesResponse> GetAsync(TVChangesRequest request) =>
            Client.GetAsync<TVChangesResponse>(
                Serialize(FormatPath("/tv/{0}/changes", request.TVId), request));
        
        public Task<TVContentRatingsResponse> GetAsync(TVContentRatingsRequest request) =>
            Client.GetAsync<TVContentRatingsResponse>(
                Serialize(FormatPath("/tv/{0}/changes", request.TVId), request));

        public Task<TVCreditsResponse> GetAsync(TVCreditsRequest request) =>
            Client.GetAsync<TVCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/credits", request.TVId), request));
        
        public Task<TVEpisodeGroupsResponse> GetAsync(TVEpisodeGroupsRequest request) =>
            Client.GetAsync<TVEpisodeGroupsResponse>(
                Serialize(FormatPath("/tv/{0}/episode_groups", request.TVId), request));

        public Task<TVExternalIdsResponse> GetAsync(TVExternalIdsRequest request) =>
            Client.GetAsync<TVExternalIdsResponse>(
                Serialize(FormatPath("/tv/{0}/external_ids", request.TVId), request));

        public Task<TVImagesResponse> GetAsync(TVImagesRequest request) =>
            Client.GetAsync<TVImagesResponse>(
                Serialize(FormatPath("/tv/{0}/images", request.TVId), request));

        public Task<TVKeywordsResponse> GetAsync(TVKeywordsRequest request) =>
            Client.GetAsync<TVKeywordsResponse>(
                Serialize(FormatPath("/tv/{0}/keywords", request.TVId), request));

        public Task<TVRecommendationsResponse> GetAsync(TVRecommendationsRequest request) =>
            Client.GetAsync<TVRecommendationsResponse>(
                Serialize(FormatPath("/tv/{0}/recommendations", request.TVId), request));

        public Task<TVReviewsResponse> GetAsync(TVReviewsRequest request) =>
            Client.GetAsync<TVReviewsResponse>(
                Serialize(FormatPath("/tv/{0}/reviews", request.TVId), request));
        
        public Task<TVScreenedTheatricallyResponse> GetAsync(TVScreenedTheatricallyRequest request) =>
            Client.GetAsync<TVScreenedTheatricallyResponse>(
                Serialize(FormatPath("/tv/{0}/screened_theatrically", request.TVId), request));

        public Task<SimilarTVResponse> GetAsync(SimilarTVRequest request) =>
            Client.GetAsync<SimilarTVResponse>(
                Serialize(FormatPath("/tv/{0}/similar", request.TVId), request));

        public Task<TVTranslationsResponse> GetAsync(TVTranslationsRequest request) =>
            Client.GetAsync<TVTranslationsResponse>(
                Serialize(FormatPath("/tv/{0}/translations", request.TVId), request));

        public Task<TVVideosResponse> GetAsync(TVVideosRequest request) =>
            Client.GetAsync<TVVideosResponse>(
                Serialize(FormatPath("/tv/{0}/videos", request.TVId), request));

        public Task<TVWatchProvidersResponse> GetAsync(TVWatchProvidersRequest request) =>
            Client.GetAsync<TVWatchProvidersResponse>(
                Serialize(FormatPath("/tv/{0}/watch/providers", request.TVId), request));

        [Obsolete("// TODO: Need to implement POST w/ body")]
        public Task<RateTVResponse> PostAsync(RateTVRequest request) =>
            Client.GetAsync<RateTVResponse>(
                Serialize(FormatPath("/tv/{0}/rating", request.TVId), request));

        [Obsolete("// TODO: Need to implement DELETE")]
        public Task<DeleteTVRatingResponse> DeleteAsync(DeleteTVRatingRequest request) =>
            Client.GetAsync<DeleteTVRatingResponse>(
                Serialize(FormatPath("/tv/{0}/rating", request.TVId), request));

        public Task<LatestTVResponse> GetAsync(LatestTVRequest request) =>
            Client.GetAsync<LatestTVResponse>(Serialize("/tv/latest", request));

        public Task<TVAiringTodayResponse> GetAsync(TVAiringTodayRequest request) =>
            Client.GetAsync<TVAiringTodayResponse>(Serialize("/tv/airing_today", request));
        
        public Task<TVOnTheAirResponse> GetAsync(TVOnTheAirRequest request) =>
            Client.GetAsync<TVOnTheAirResponse>(Serialize("/tv/airing_today", request));

        public Task<PopularTVResponse> GetAsync(PopularTVRequest request) =>
            Client.GetAsync<PopularTVResponse>(Serialize("/tv/popular", request));

        public Task<TopRatedTVResponse> GetAsync(TopRatedTVRequest request) =>
            Client.GetAsync<TopRatedTVResponse>(Serialize("/tv/top_rated", request));
    }
}