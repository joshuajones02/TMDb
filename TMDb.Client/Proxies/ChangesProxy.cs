using System.Threading.Tasks;
using TMDb.Client.Models.Proxies.Changes;

namespace TMDb.Client.Proxies
{
    public class ChangesProxy : ProxyBase
    {
        public ChangesProxy(TMDbClient client) : base(client)
        {
        }

        public Task<ChangeListResponse> GetAsync(MovieChangeListRequest request) =>
            Client.GetAsync<ChangeListResponse>(Serialize("/movie/changes", request));

        public Task<ChangeListResponse> GetAsync(PersonChangeListRequest request) =>
            Client.GetAsync<ChangeListResponse>(Serialize("/tv/changes", request));

        public Task<ChangeListResponse> GetAsync(TVChangeListRequest request) =>
            Client.GetAsync<ChangeListResponse>(Serialize("/person/changes", request));
    }
}