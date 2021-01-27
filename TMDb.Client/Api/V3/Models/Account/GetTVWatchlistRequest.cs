using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/watchlist/tv")]
    public class GetTVWatchlistRequest : AccountListBaseRequest
    {
    }
}