using System;
using System.Threading.Tasks;
using TMDb.Client.Models;

namespace TMDb.Client.Proxies
{
    public class MoviesProxy : ProxyBase
    {
        public MoviesProxy(TMDbClient client) : base(client) =>
            Path = "/movie/{0}";

        protected string Path { get; }

        public Task<MovieResponse> GetDetailsAsync(int movieId) =>
            Client.GetAsync<MovieResponse>(FormatPathAndSerialize("/movie/{0}", movieId, new MovieDetailsRequest()));

        public Task<MovieListResponse> GetRecommendationsAsync(int movieId, int page) =>
            Client.GetAsync<MovieListResponse>(FormatPathAndSerialize("/movie/{0}/recommendations", movieId, new MovieDetailsListRequest(page)));

        public Task<MovieListResponse> GetSimilarMoviesAsync(int movieId, int page) =>
            Client.GetAsync<MovieListResponse>(FormatPathAndSerialize("/movie/{0}/similar", movieId, new MovieDetailsListRequest(page)));

        public Task<MovieListResponse> GetLatestAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/latest", new MovieDetailsListRequest(page)));

        public Task<MovieListResponse> GetNowPlayingAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/now_playing", new MovieDetailsListRequest(page)));

        public Task<MovieListResponse> GetPopularAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/popular", new MovieDetailsListRequest(page)));

        public Task<MovieListResponse> GetTopRatedAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/top_rated", new MovieDetailsListRequest(page)));

        public Task<MovieListResponse> GetUpcommingAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/upcoming", new MovieDetailsListRequest(page)));

        public Task<MovieVideoResponse> GetVideosAsync(int movieId) =>
            Client.GetAsync<MovieVideoResponse>(FormatPathAndSerialize("/movie/{0}/videos", movieId, new TMDbRequest()));

        private Uri FormatPathAndSerialize(string path, int movieId, TMDbRequest request) =>
            Serialize(string.Format(path, movieId), request);
    }
}