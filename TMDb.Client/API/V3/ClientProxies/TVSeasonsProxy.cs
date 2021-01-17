using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.TVSeasons;

namespace TMDb.Client.API.V3.ClientProxies
{
    [Obsolete("// TODO: Rewrite all proxies to take and return a generic parameter and the parameter insides the models will be used instead of writing each one out")]
    public class TVSeasonsProxy : ApiProxy
    {
        public TVSeasonsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual string FormatPath(string path, int seasonId) =>
            string.Format(path, seasonId);

        public virtual string FormatPath(string path, int tvId, int seasonNumber) =>
            string.Format(path, tvId, seasonNumber);

        public virtual Task<TVSeasonsDetailsResponse> GetAsync(TVSeasonsDetailsRequest request) =>
            Client.GetAsync<TVSeasonsDetailsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsAccountStatesResponse> GetAsync(TVSeasonsAccountStatesRequest request) =>
            Client.GetAsync<TVSeasonsAccountStatesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/account_states", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsAggregateCreditsResponse> GetAsync(TVSeasonsAggregateCreditsRequest request) =>
            Client.GetAsync<TVSeasonsAggregateCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/aggregate_credits", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsChangesResponse> GetAsync(TVSeasonsChangesRequest request) =>
            Client.GetAsync<TVSeasonsChangesResponse>(
                Serialize(FormatPath("/tv/season/{0}/changes", request.SeasonId), request));

        public virtual Task<TVSeasonsCreditsResponse> GetAsync(TVSeasonsCreditsRequest request) =>
            Client.GetAsync<TVSeasonsCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/credits", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsExternalIdsResponse> GetAsync(TVSeasonsExternalIdsRequest request) =>
            Client.GetAsync<TVSeasonsExternalIdsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/external_ids", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsImagesResponse> GetAsync(TVSeasonsImagesRequest request) =>
            Client.GetAsync<TVSeasonsImagesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/images", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsTranslationsResponse> GetAsync(TVSeasonsTranslationsRequest request) =>
            Client.GetAsync<TVSeasonsTranslationsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/translations", request.TvId, request.SeasonNumber), request));

        public virtual Task<TVSeasonsVideosResponse> GetAsync(TVSeasonsVideosRequest request) =>
            Client.GetAsync<TVSeasonsVideosResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/videos", request.TvId, request.SeasonNumber), request));
    }
}