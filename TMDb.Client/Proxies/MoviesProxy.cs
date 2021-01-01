using TMDb.Client.Models;
using System;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class MoviesProxy : TMDbProxy
    {
        public MoviesProxy(TMDbClient client) : base(client) =>
            Path = "/movie/{0}";

        protected string Path { get; }

        public Task<MovieDetailsResponse> GetDetailsAsync(int movieId) =>
            Client.GetAsync<MovieDetailsResponse>(FormatPathAndSerialize("/movie/{0}", movieId, new MovieDetailsRequest()));

        public Task<MovieListResponse> GetRecommendationsAsync(int movieId, int page) =>
            Client.GetAsync<MovieListResponse>(FormatPathAndSerialize("/movie/{0}/recommendations", movieId, new MovieListRequest(page)));

        public Task<MovieListResponse> GetSimilarMoviesAsync(int movieId, int page) =>
            Client.GetAsync<MovieListResponse>(FormatPathAndSerialize("/movie/{0}/similar", movieId, new MovieListRequest(page)));

        public Task<MovieListResponse> GetLatestAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/latest", new MovieListRequest(page)));

        public Task<MovieListResponse> GetNowPlayingAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/now_playing", new MovieListRequest(page)));

        public Task<MovieListResponse> GetPopularAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/popular", new MovieListRequest(page)));

        public Task<MovieListResponse> GetTopRatedAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/top_rated", new MovieListRequest(page)));

        public Task<MovieListResponse> GetUpcommingAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/upcoming", new MovieListRequest(page)));

        public Task<MovieVideoResponse> GetVideosAsync(int movieId) =>
            Client.GetAsync<MovieVideoResponse>(FormatPathAndSerialize("/movie/{0}/videos", movieId, new TMDbRequest()));

        private Uri FormatPathAndSerialize(string path, int movieId, TMDbRequest request) =>
            Serialize(string.Format(path, movieId), request);
    }
}