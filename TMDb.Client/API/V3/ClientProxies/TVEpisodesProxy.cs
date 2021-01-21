using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.TVEpisodes;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class TVEpisodesProxy : ApiProxy
    {
        public TVEpisodesProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<TVEpisodesDetailsResponse> GetAsync(TVEpisodesDetailsRequest request) =>
            Client.SendAsync<TVEpisodesDetailsResponse>(request);

        public virtual Task<TVEpisodesAccountStatesResponse> GetAsync(TVEpisodesAccountStatesRequest request) =>
            Client.SendAsync<TVEpisodesAccountStatesResponse>(request);

        public virtual Task<TVEpisodesChangesResponse> GetAsync(TVEpisodesChangesRequest request) =>
            Client.SendAsync<TVEpisodesChangesResponse>(request);

        public virtual Task<TVEpisodesCreditsResponse> GetAsync(TVEpisodesCreditsRequest request) =>
            Client.SendAsync<TVEpisodesCreditsResponse>(request);

        public virtual Task<TVEpisodesExternalIdsResponse> GetAsync(TVEpisodesExternalIdsRequest request) =>
            Client.SendAsync<TVEpisodesExternalIdsResponse>(request);

        public virtual Task<TVEpisodesImagesResponse> GetAsync(TVEpisodesImagesRequest request) =>
            Client.SendAsync<TVEpisodesImagesResponse>(request);

        public virtual Task<TVEpisodesTranslationsResponse> GetAsync(TVEpisodesTranslationsRequest request) =>
            Client.SendAsync<TVEpisodesTranslationsResponse>(request);

        public virtual Task<TVEpisodesVideosResponse> GetAsync(TVEpisodesVideosRequest request) =>
            Client.SendAsync<TVEpisodesVideosResponse>(request);

        public virtual Task<RateTVEpisodeResponse> PostAsync(RateTVEpisodeRequest request) =>
            Client.SendAsync<RateTVEpisodeResponse>(request);

        public virtual Task<DeleteTVEpisodeRatingResponse> DeleteAsync(DeleteTVEpisodeRatingRequest request) =>
            Client.SendAsync<DeleteTVEpisodeRatingResponse>(request);
    }
}