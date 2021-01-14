using System.Threading.Tasks;
using TMDb.Client.Enums;
using TMDb.Client.Models;

namespace TMDb.Client.Proxies
{
    public class TrendingProxy : ProxyBase
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