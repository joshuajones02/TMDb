using TMDb.Client.Models;
using System;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class TVProxy : ProxyBase
    {
        public TVProxy(TMDbClient client) : base(client) =>
            Path = "/tv/{0}";

        protected string Path { get; }

        public Task<TVDetailsResponse> GetDetailsAsync(int tvId) =>
            Client.GetAsync<TVDetailsResponse>(FormatPathAndSerialize(Path, tvId, new TVDetailsRequest()));

        public Task<TVListResponse> GetAiringTodayAsync(int page) =>
            Client.GetAsync<TVListResponse>(Serialize("/tv/airing_today", new TVListRequest(page)));

        public Task<TVListResponse> GetOnTheAirAsync(int page) =>
            Client.GetAsync<TVListResponse>(Serialize("/tv/on_the_air", new TVListRequest(page)));

        public Task<TVListResponse> GetPopularAsync(int page) =>
            Client.GetAsync<TVListResponse>(Serialize("/tv/popular", new TVListRequest(page)));

        public Task<TVListResponse> GetTopRatedAsync(int page) =>
            Client.GetAsync<TVListResponse>(Serialize("/tv/top_rated", new TVListRequest(page)));

        public Task<TVListResponse> GetRecommendationsAsync(int tvId, int page) =>
            Client.GetAsync<TVListResponse>(FormatPathAndSerialize("/tv/{0}/recommendations", tvId, new TVListRequest(page)));

        public Task<TVListResponse> GetSimilarAsync(int tvId, int page) =>
            Client.GetAsync<TVListResponse>(FormatPathAndSerialize("/tv/{0}/similar", tvId, new TVListRequest(page)));

        public Task<TVVideoResponse> GetVideosAsync(int tvId) =>
            Client.GetAsync<TVVideoResponse>(FormatPathAndSerialize("/tv/{0}/videos", tvId, new TVVideoRequest()));

        private Uri FormatPathAndSerialize(string path, int tvId, TMDbRequest request) =>
            Serialize(string.Format(path, tvId), request);
    }
}