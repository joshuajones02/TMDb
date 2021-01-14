using System.Threading.Tasks;
using TMDb.Client.Models.Proxies.TVEpisodes;

namespace TMDb.Client.Proxies
{
    public class TVEpisodesProxy : ProxyBase
    {
        public TVEpisodesProxy(TMDbClient client) : base(client) 
        {
        }

        // TODO: Finished response models   

        public string FormatPath(string path, int episodeId) =>
            string.Format(path, episodeId);

        public string FormatPath(string path, int tvId, int seasonNumber, int episodeNumber) =>
            string.Format(path, tvId, seasonNumber, episodeNumber);

        public Task<TVEpisodesDetailsResponse> GetAsync(TVEpisodesDetailsRequest request) =>
            Client.GetAsync<TVEpisodesDetailsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesAccountStatesResponse> GetAsync(TVEpisodesAccountStatesRequest request) =>
            Client.GetAsync<TVEpisodesAccountStatesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/account_states", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesChangesResponse> GetAsync(TVEpisodesChangesRequest request) =>
            Client.GetAsync<TVEpisodesChangesResponse>(
                Serialize(FormatPath("/tv/episode/{0}/changes", request.EpisodeId), request));

        public Task<TVEpisodesCreditsResponse> GetAsync(TVEpisodesCreditsRequest request) =>
            Client.GetAsync<TVEpisodesCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/credits", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesExternalIdsResponse> GetAsync(TVEpisodesExternalIdsRequest request) =>
            Client.GetAsync<TVEpisodesExternalIdsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/external_ids", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesImagesResponse> GetAsync(TVEpisodesImagesRequest request) =>
            Client.GetAsync<TVEpisodesImagesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/images", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesTranslationsResponse> GetAsync(TVEpisodesTranslationsRequest request) =>
            Client.GetAsync<TVEpisodesTranslationsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/translations", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesVideosResponse> GetAsync(TVEpisodesVideosRequest request) =>
            Client.GetAsync<TVEpisodesVideosResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/videos", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesPostRatingResponse> PostAsync(TVEpisodesPostRatingRequest request) =>
            Client.GetAsync<TVEpisodesPostRatingResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/rating", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public Task<TVEpisodesVideosResponse> DeleteAsync(TVEpisodesPostRatingRequest request) =>
            Client.GetAsync<TVEpisodesVideosResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/rating", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));
    }
}