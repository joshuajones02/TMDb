using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Reviews;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class ReviewsProxy : ApiProxy
    {
        private static readonly TMDbRequest _request;

        static ReviewsProxy() =>
            _request = new TMDbRequest();

        public ReviewsProxy(TMDbClient client) : base(client)
        {
        }

        private string FormatPath(string path, string reviewId) =>
            string.Format(path, reviewId);

        public Task<ReviewsResponse> GetDetails(string reviewId) =>
            Client.GetAsync<ReviewsResponse>(
                Serialize(FormatPath("/credit/{0}", reviewId), _request));
    }
}