using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Reviews;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class ReviewsProxy : ApiProxy
    {
        public ReviewsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<ReviewsResponse> GetAsync(ReviewsRequest request) =>
            Client.SendAsync<ReviewsResponse>(request);
    }
}