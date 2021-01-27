using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/rated/tv")]
    public class GetRatedTVRequest : AccountListBaseRequest
    {
    }
}