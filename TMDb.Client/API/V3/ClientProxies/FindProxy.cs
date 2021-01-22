using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Find;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class FindProxy : ApiProxy
    {
        public FindProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<FindByIdResponse> GetAsync(FindByIdRequest request) =>
            Client.SendAsync<FindByIdResponse>(request);
    }
}