using TMDb.Client.Models;
using System;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class TVEpisodesProxy : ProxyBase
    {
        public TVEpisodesProxy(TMDbClient client) : base(client) =>
            Path = "/tv/{0}/season/{1}/episode/{2}";

        protected string Path { get; }

        public Task<TVEpisodeDetailsResponse> GetDetailsAsync(int tvId, int seasonNumber, int episodeNumber) =>
            Client.GetAsync<TVEpisodeDetailsResponse>(FormatPathAndSerialize(Path, tvId, seasonNumber, episodeNumber, new TVEpisodeDetailsRequest()));

        public Task<TVVideoResponse> GetVideosAsync(int tvId, int seasonNumber, int episodeNumber) =>
            Client.GetAsync<TVVideoResponse>(FormatPathAndSerialize("/tv/{0}/season/{1}/episode/{2}/videos", tvId, seasonNumber, episodeNumber, new TVVideoRequest()));

        private Uri FormatPathAndSerialize(string path, int tvId, int seasonNumber, int episodeNumber, TMDbRequest request) =>
            Serialize(string.Format(path, tvId, seasonNumber, episodeNumber), request);
    }
}