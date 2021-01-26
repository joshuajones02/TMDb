using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiPostEndpoint("/account/{account_id}/favorite")]
    public class MarkAsFavoriteRequest : TMDbRequest
    {
    }
}