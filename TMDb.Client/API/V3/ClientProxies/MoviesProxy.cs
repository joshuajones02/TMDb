using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Movies;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class MoviesProxy : ApiProxy
    {
        public MoviesProxy(TMDbClient client) : base(client)
        {
        }

        private string FormatPath(string path, int movieId) =>
            string.Format(path, movieId);

        public Task<MovieDetailsResponse> GetAsync(MovieDetailsRequest request) =>
            Client.GetAsync<MovieDetailsResponse>(
                Serialize(FormatPath("/movie/{0}", request.MovieId), request));

        public Task<MovieAccountStatesResponse> GetAsync(MovieAccountStatesRequest request) =>
            Client.GetAsync<MovieAccountStatesResponse>(
                Serialize(FormatPath("/movie/{0}/account_states", request.MovieId), request));

        public Task<AlternativeMovieTitlesResponse> GetAsync(AlternativeMovieTitlesRequest request) =>
            Client.GetAsync<AlternativeMovieTitlesResponse>(
                Serialize(FormatPath("/movie/{0}/alternative_titles", request.MovieId), request));

        public Task<MovieChangesResponse> GetAsync(MovieChangesRequest request) =>
            Client.GetAsync<MovieChangesResponse>(
                Serialize(FormatPath("/movie/{0}/changes", request.MovieId), request));

        public Task<MovieCreditsResponse> GetAsync(MovieCreditsRequest request) =>
            Client.GetAsync<MovieCreditsResponse>(
                Serialize(FormatPath("/movie/{0}/credits", request.MovieId), request));

        public Task<MovieExternalIdsResponse> GetAsync(MovieExternalIdsRequest request) =>
            Client.GetAsync<MovieExternalIdsResponse>(
                Serialize(FormatPath("/movie/{0}/external_ids", request.MovieId), request));

        public Task<MovieImagesResponse> GetAsync(MovieImagesRequest request) =>
            Client.GetAsync<MovieImagesResponse>(
                Serialize(FormatPath("/movie/{0}/images", request.MovieId), request));

        public Task<MovieKeywordsResponse> GetAsync(MovieKeywordsRequest request) =>
            Client.GetAsync<MovieKeywordsResponse>(
                Serialize(FormatPath("/movie/{0}/keywords", request.MovieId), request));

        public Task<MovieListsResponse> GetAsync(MovieListsRequest request) =>
            Client.GetAsync<MovieListsResponse>(
                Serialize(FormatPath("/movie/{0}/lists", request.MovieId), request));

        public Task<MovieRecommendationsResponse> GetAsync(MovieRecommendationsRequest request) =>
            Client.GetAsync<MovieRecommendationsResponse>(
                Serialize(FormatPath("/movie/{0}/recommendations", request.MovieId), request));

        public Task<MovieReleaseDatesResponse> GetAsync(MovieReleaseDatesRequest request) =>
            Client.GetAsync<MovieReleaseDatesResponse>(
                Serialize(FormatPath("/movie/{0}/release_dates", request.MovieId), request));

        public Task<MovieReviewsResponse> GetAsync(MovieReviewsRequest request) =>
            Client.GetAsync<MovieReviewsResponse>(
                Serialize(FormatPath("/movie/{0}/reviews", request.MovieId), request));

        public Task<SimilarMoviesResponse> GetAsync(SimilarMoviesRequest request) =>
            Client.GetAsync<SimilarMoviesResponse>(
                Serialize(FormatPath("/movie/{0}/similar", request.MovieId), request));

        public Task<MovieTranslationsResponse> GetAsync(MovieTranslationsRequest request) =>
            Client.GetAsync<MovieTranslationsResponse>(
                Serialize(FormatPath("/movie/{0}/translations", request.MovieId), request));

        public Task<MovieVideosResponse> GetAsync(MovieVideosRequest request) =>
            Client.GetAsync<MovieVideosResponse>(
                Serialize(FormatPath("/movie/{0}/videos", request.MovieId), request));

        public Task<MovieWatchProvidersResponse> GetAsync(MovieWatchProvidersRequest request) =>
            Client.GetAsync<MovieWatchProvidersResponse>(
                Serialize(FormatPath("/movie/{0}/watch/providers", request.MovieId), request));

        [Obsolete("// TODO: Need to implement POST w/ body")]
        public Task<RateMovieResponse> PostAsync(RateMovieRequest request) =>
            Client.GetAsync<RateMovieResponse>(
                Serialize(FormatPath("/movie/{0}/rating", request.MovieId), request));

        [Obsolete("// TODO: Need to implement DELETE")]
        public Task<DeleteMovieRatingResponse> DeleteAsync(DeleteMovieRatingRequest request) =>
            Client.GetAsync<DeleteMovieRatingResponse>(
                Serialize(FormatPath("/movie/{0}/rating", request.MovieId), request));

        public Task<LatestMoviesResponse> GetAsync(LatestMoviesRequest request) =>
            Client.GetAsync<LatestMoviesResponse>(Serialize("/movie/latest", request));

        public Task<NowPlayingMoviesResponse> GetAsync(NowPlayingMoviesRequest request) =>
            Client.GetAsync<NowPlayingMoviesResponse>(Serialize("/movie/now_playing", request));

        public Task<PopularMoviesResponse> GetAsync(PopularMoviesRequest request) =>
            Client.GetAsync<PopularMoviesResponse>(Serialize("/movie/popular", request));

        public Task<TopRatedMoviesResponse> GetAsync(TopRatedMoviesRequest request) =>
            Client.GetAsync<TopRatedMoviesResponse>(Serialize("/movie/top_rated", request));

        public Task<UpcomingMoviesResponse> GetAsync(UpcomingMoviesRequest request) =>
            Client.GetAsync<UpcomingMoviesResponse>(Serialize("/movie/upcoming", request));
    }
}