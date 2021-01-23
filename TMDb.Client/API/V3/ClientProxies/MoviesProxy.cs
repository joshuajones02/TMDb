using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Movies;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class MoviesProxy : ApiProxy
    {
        public MoviesProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<MovieDetailsResponse> GetAsync(MovieDetailsRequest request) =>
            Client.SendAsync<MovieDetailsResponse>(request);

        public virtual Task<MovieAccountStatesResponse> GetAsync(MovieAccountStatesRequest request) =>
            Client.SendAsync<MovieAccountStatesResponse>(request);

        public virtual Task<AlternativeMovieTitlesResponse> GetAsync(AlternativeMovieTitlesRequest request) =>
            Client.SendAsync<AlternativeMovieTitlesResponse>(request);

        public virtual Task<MovieChangesResponse> GetAsync(MovieChangesRequest request) =>
            Client.SendAsync<MovieChangesResponse>(request);

        public virtual Task<MovieCreditsResponse> GetAsync(MovieCreditsRequest request) =>
            Client.SendAsync<MovieCreditsResponse>(request);

        public virtual Task<MovieExternalIdsResponse> GetAsync(MovieExternalIdsRequest request) =>
            Client.SendAsync<MovieExternalIdsResponse>(request);
        
        public virtual Task<MovieImagesResponse> GetAsync(MovieImagesRequest request) =>
            Client.SendAsync<MovieImagesResponse>(request);
        
        public virtual Task<MovieKeywordsResponse> GetAsync(MovieKeywordsRequest request) =>
            Client.SendAsync<MovieKeywordsResponse>(request);
        
        public virtual Task<MovieListsResponse> GetAsync(MovieListsRequest request) =>
            Client.SendAsync<MovieListsResponse>(request);

        public virtual Task<MovieRecommendationsResponse> GetAsync(MovieRecommendationsRequest request) =>
            Client.SendAsync<MovieRecommendationsResponse>(request);

        public virtual Task<MovieReleaseDatesResponse> GetAsync(MovieReleaseDatesRequest request) =>
            Client.SendAsync<MovieReleaseDatesResponse>(request);

        public virtual Task<MovieReviewsResponse> GetAsync(MovieReviewsRequest request) =>
            Client.SendAsync<MovieReviewsResponse>(request);

        public virtual Task<SimilarMoviesResponse> GetAsync(SimilarMoviesRequest request) =>
            Client.SendAsync<SimilarMoviesResponse>(request);

        public virtual Task<MovieTranslationsResponse> GetAsync(MovieTranslationsRequest request) =>
            Client.SendAsync<MovieTranslationsResponse>(request);

        public virtual Task<MovieVideosResponse> GetAsync(MovieVideosRequest request) =>
            Client.SendAsync<MovieVideosResponse>(request);

        public virtual Task<MovieWatchProvidersResponse> GetAsync(MovieWatchProvidersRequest request) =>
            Client.SendAsync<MovieWatchProvidersResponse>(request);

        public virtual Task<RateMovieResponse> PostAsync(RateMovieRequest request) =>
            Client.SendAsync<RateMovieResponse>(request);

        public virtual Task<DeleteMovieRatingResponse> DeleteAsync(DeleteMovieRatingRequest request) =>
            Client.SendAsync<DeleteMovieRatingResponse>(request);

        public virtual Task<LatestMoviesResponse> GetAsync(LatestMoviesRequest request) =>
            Client.SendAsync<LatestMoviesResponse>(request);

        public virtual Task<NowPlayingMoviesResponse> GetAsync(NowPlayingMoviesRequest request) =>
            Client.SendAsync<NowPlayingMoviesResponse>(request);

        public virtual Task<PopularMoviesResponse> GetAsync(PopularMoviesRequest request) =>
            Client.SendAsync<PopularMoviesResponse>(request);

        public virtual Task<TopRatedMoviesResponse> GetAsync(TopRatedMoviesRequest request) =>
            Client.SendAsync<TopRatedMoviesResponse>(request);

        public virtual Task<UpcomingMoviesResponse> GetAsync(UpcomingMoviesRequest request) =>
            Client.SendAsync<UpcomingMoviesResponse>(request);
    }
}