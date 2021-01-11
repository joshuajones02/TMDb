using System.Threading.Tasks;
using TMDb.Client.Models;
using TMDb.Client.Models.Proxies.Reviews;

namespace TMDb.Client.Proxies
{
    public class ReviewsProxy : ProxyBase
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