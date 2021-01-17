using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Changes;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class ChangesProxy : ApiProxy
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