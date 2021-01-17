using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models;
using TMDb.Client.API.V3.Models.Movie;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class MoviesProxy : ApiProxy
    {
        public MoviesProxy(TMDbClient client) : base(client) =>
            Path = "/movie/{0}";

        protected string Path { get; }

        public virtual Task<MovieResponse> GetDetailsAsync(int movieId) =>
            Client.GetAsync<MovieResponse>(FormatPathAndSerialize("/movie/{0}", movieId, new MovieDetailsRequest()));

        public virtual Task<MovieListResponse> GetRecommendationsAsync(int movieId, int page) =>
            Client.GetAsync<MovieListResponse>(FormatPathAndSerialize("/movie/{0}/recommendations", movieId, new MovieDetailsListRequest(page)));

        public virtual Task<MovieListResponse> GetSimilarMoviesAsync(int movieId, int page) =>
            Client.GetAsync<MovieListResponse>(FormatPathAndSerialize("/movie/{0}/similar", movieId, new MovieDetailsListRequest(page)));

        public virtual Task<MovieListResponse> GetLatestAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/latest", new MovieDetailsListRequest(page)));

        public virtual Task<MovieListResponse> GetNowPlayingAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/now_playing", new MovieDetailsListRequest(page)));

        public virtual Task<MovieListResponse> GetPopularAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/popular", new MovieDetailsListRequest(page)));

        public virtual Task<MovieListResponse> GetTopRatedAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/top_rated", new MovieDetailsListRequest(page)));

        public virtual Task<MovieListResponse> GetUpcommingAsync(int page) =>
            Client.GetAsync<MovieListResponse>(Serialize("/movie/upcoming", new MovieDetailsListRequest(page)));

        public virtual Task<MovieVideoResponse> GetVideosAsync(int movieId) =>
            Client.GetAsync<MovieVideoResponse>(FormatPathAndSerialize("/movie/{0}/videos", movieId, new MovieVideoRequest()));

        private Uri FormatPathAndSerialize(string path, int movieId, TMDbRequest request) =>
            Serialize(string.Format(path, movieId), request);
    }
}