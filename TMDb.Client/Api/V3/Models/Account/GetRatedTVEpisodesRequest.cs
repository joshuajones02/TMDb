using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Account
{
    [ApiGetEndpoint("/account/{account_id}/rated/tv/episodes")]
    public class GetRatedTVEpisodesRequest : TMDbRequest
    {
    }
}