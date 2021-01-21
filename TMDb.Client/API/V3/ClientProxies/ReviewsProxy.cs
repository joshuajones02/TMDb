using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Reviews;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class ReviewsProxy : ApiProxy
    {
        public ReviewsProxy(TMDbClient client) : base(client)
        {
        }

        private string FormatPath(string path, string reviewId) =>
            string.Format(path, reviewId);

        public virtual Task<ReviewsResponse> GetDetails(ReviewsRequest request) =>
            Client.GetAsync<ReviewsResponse>(
                Serialize(FormatPath("/credit/{0}", request.ReviewId), request));
    }
}