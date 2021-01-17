using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Credits;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class CreditsProxy : ApiProxy
    {
        public CreditsProxy(TMDbClient client) : base(client)
        {
        }

        private string FormatPath(string path, string creditId) =>
            string.Format(path, creditId);

        [Obsolete("// TODO: Need to format path with credits ID path parameter")]
        public virtual Task<CreditsResponse> Get(CreditsRequest request) =>
            Client.GetAsync<CreditsResponse>(
                Serialize(FormatPath("/credit/{0}", request.CreditId), request));
    }
}