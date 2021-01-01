using TMDb.Client.Models;
using System;
using System.Threading.Tasks;

namespace TMDb.Client.Proxies
{
    public class TVSeasonsProxy : TMDbProxy
    {
        public TVSeasonsProxy(TMDbClient client) : base(client) =>
            Path = "/tv/{0}/season/{1}";

        protected string Path { get; }

        public Task<TVSeasonDetailsResponse> GetDetailsAsync(int movieId, int seasonNumber) =>
            Client.GetAsync<TVSeasonDetailsResponse>(FormatPathAndSerialize(Path, movieId, seasonNumber, new TVSeasonDetailsRequest()));

        public Task<TVVideoResponse> GetVideosAsync(int movieId, int seasonNumber) =>
            Client.GetAsync<TVVideoResponse>(FormatPathAndSerialize("/tv/{0}/season/{1}/videos", movieId, seasonNumber, new TVVideoRequest()));

        private Uri FormatPathAndSerialize(string path, int movieId, int seasonNumber, TMDbRequest request) =>
            Serialize(string.Format(path, movieId, seasonNumber), request);
    }
}