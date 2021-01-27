using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Account;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class AccountProxy : ApiProxy
    {
        public AccountProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<GetAccountDetailsResponse> GetAsync(GetAccountDetailsRequest request) =>
            Client.SendAsync<GetAccountDetailsResponse>(request);

        public virtual Task<GetCreatedListsResponse> GetAsync(GetCreatedListsRequest request) =>
            Client.SendAsync<GetCreatedListsResponse>(request);

        public virtual Task<GetFavoriteMoviesResponse> GetAsync(GetFavoriteMoviesRequest request) =>
            Client.SendAsync<GetFavoriteMoviesResponse>(request);

        public virtual Task<GetFavoriteTVResponse> GetAsync(GetFavoriteTVRequest request) =>
            Client.SendAsync<GetFavoriteTVResponse>(request);

        public virtual Task<MarkAsFavoriteResponse> PostAsync(MarkAsFavoriteRequest request) =>
            Client.SendAsync<MarkAsFavoriteResponse>(request);

        public virtual Task<GetRatedMoviesResponse> GetAsync(GetRatedMoviesRequest request) =>
            Client.SendAsync<GetRatedMoviesResponse>(request);

        public virtual Task<GetRatedTVResponse> GetAsync(GetRatedTVRequest request) =>
            Client.SendAsync<GetRatedTVResponse>(request);

        public virtual Task<GetRatedTVEpisodesResponse> GetAsync(GetRatedTVEpisodesRequest request) =>
            Client.SendAsync<GetRatedTVEpisodesResponse>(request);

        public virtual Task<GetMovieWatchlistResponse> GetAsync(GetMovieWatchlistRequest request) =>
            Client.SendAsync<GetMovieWatchlistResponse>(request);

        public virtual Task<GetTVWatchlistResponse> GetAsync(GetTVWatchlistRequest request) =>
            Client.SendAsync<GetTVWatchlistResponse>(request);

        public virtual Task<AddToWatchlistResponse> PostAsync(AddToWatchlistRequest request) =>
            Client.SendAsync<AddToWatchlistResponse>(request);
    }
}