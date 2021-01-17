using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Trending;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class TrendingProxy : ApiProxy
    {
        public TrendingProxy(TMDbClient client) : base(client) =>
            Path = "/trending/{0}/{1}";

        protected string Path { get; }

        public Task<TrendingResponse> GetAsync(int page, MediaType type, TimeWindow time) =>
            Client.GetAsync<TrendingResponse>(Serialize(FormatPath(type, time), new TrendingRequest(page)));

        private string FormatPath(MediaType type, TimeWindow time) =>
            string.Format(Path, type.ToString(), time.ToString());
    }
}