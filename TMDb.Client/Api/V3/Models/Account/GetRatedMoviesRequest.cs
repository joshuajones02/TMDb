using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/rated/movies")]
    public class GetRatedMoviesRequest : AccountListBaseRequest
    {
    }
}