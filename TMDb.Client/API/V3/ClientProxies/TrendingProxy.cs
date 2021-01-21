using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Trending;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class TrendingProxy : ApiProxy
    {
        public TrendingProxy(TMDbClient client) : base(client) 
        {
        }

        public virtual Task<TrendingResponse> GetAsync(TrendingRequest request) =>
            Client.SendAsync<TrendingResponse>(request);
    }
}