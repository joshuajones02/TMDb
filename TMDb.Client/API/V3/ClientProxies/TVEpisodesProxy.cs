using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.TVEpisodes;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class TVEpisodesProxy : ApiProxy
    {
        public TVEpisodesProxy(TMDbClient client) : base(client)
        {
        }

        // TODO: Finished response models

        public virtual string FormatPath(string path, int episodeId) =>
            string.Format(path, episodeId);

        public virtual string FormatPath(string path, int tvId, int seasonNumber, int episodeNumber) =>
            string.Format(path, tvId, seasonNumber, episodeNumber);

        public virtual Task<TVEpisodesDetailsResponse> GetAsync(TVEpisodesDetailsRequest request) =>
            Client.GetAsync<TVEpisodesDetailsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesAccountStatesResponse> GetAsync(TVEpisodesAccountStatesRequest request) =>
            Client.GetAsync<TVEpisodesAccountStatesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/account_states", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesChangesResponse> GetAsync(TVEpisodesChangesRequest request) =>
            Client.GetAsync<TVEpisodesChangesResponse>(
                Serialize(FormatPath("/tv/episode/{0}/changes", request.EpisodeId), request));

        public virtual Task<TVEpisodesCreditsResponse> GetAsync(TVEpisodesCreditsRequest request) =>
            Client.GetAsync<TVEpisodesCreditsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/credits", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesExternalIdsResponse> GetAsync(TVEpisodesExternalIdsRequest request) =>
            Client.GetAsync<TVEpisodesExternalIdsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/external_ids", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesImagesResponse> GetAsync(TVEpisodesImagesRequest request) =>
            Client.GetAsync<TVEpisodesImagesResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/images", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesTranslationsResponse> GetAsync(TVEpisodesTranslationsRequest request) =>
            Client.GetAsync<TVEpisodesTranslationsResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/translations", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesVideosResponse> GetAsync(TVEpisodesVideosRequest request) =>
            Client.GetAsync<TVEpisodesVideosResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/videos", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesPostRatingResponse> PostAsync(TVEpisodesPostRatingRequest request) =>
            Client.GetAsync<TVEpisodesPostRatingResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/rating", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));

        public virtual Task<TVEpisodesVideosResponse> DeleteAsync(TVEpisodesPostRatingRequest request) =>
            Client.GetAsync<TVEpisodesVideosResponse>(
                Serialize(FormatPath("/tv/{0}/season/{1}/episode/{2}/rating", request.TvId, request.SeasonNumber, request.EpisodeNumber), request));
    }
}