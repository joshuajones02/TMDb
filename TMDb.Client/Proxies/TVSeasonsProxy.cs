using System.Threading.Tasks;
using TMDb.Client.Models.Proxies.TVSeasons;

namespace TMDb.Client.Proxies
{
    public class TVSeasonsProxy : ProxyBase
    {
        public TVSeasonsProxy(TMDbClient client) : base(client)
        {
        }

        public string FormatPath(string path, int seasonId) =>
            string.Format(path, seasonId);

        public string FormatPath(string path, int tvId, int seasonNumber) =>
            string.Format(path, tvId, seasonNumber);

        public Task<TVSeasonsDetailsResponse> GetAsync(TVSeasonsDetailsRequest request) =>
            Client.GetAsync<TVSeasonsDetailsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsAccountStatesResponse> GetAsync(TVSeasonsAccountStatesRequest request) =>
            Client.GetAsync<TVSeasonsAccountStatesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/account_states", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsAggregateCreditsResponse> GetAsync(TVSeasonsAggregateCreditsRequest request) =>
            Client.GetAsync<TVSeasonsAggregateCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/aggregate_credits", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsChangesResponse> GetAsync(TVSeasonsChangesRequest request) =>
            Client.GetAsync<TVSeasonsChangesResponse>(
                Serialize(FormatPath("/tv/season/{0}/changes", request.SeasonId), request));

        public Task<TVSeasonsCreditsResponse> GetAsync(TVSeasonsCreditsRequest request) =>
            Client.GetAsync<TVSeasonsCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/credits", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsExternalIdsResponse> GetAsync(TVSeasonsExternalIdsRequest request) =>
            Client.GetAsync<TVSeasonsExternalIdsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/external_ids", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsImagesResponse> GetAsync(TVSeasonsImagesRequest request) =>
            Client.GetAsync<TVSeasonsImagesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/images", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsTranslationsResponse> GetAsync(TVSeasonsTranslationsRequest request) =>
            Client.GetAsync<TVSeasonsTranslationsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/translations", request.TvId, request.SeasonNumber), request));

        public Task<TVSeasonsVideosResponse> GetAsync(TVSeasonsVideosRequest request) =>
            Client.GetAsync<TVSeasonsVideosResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/videos", request.TvId, request.SeasonNumber), request));
    }
}