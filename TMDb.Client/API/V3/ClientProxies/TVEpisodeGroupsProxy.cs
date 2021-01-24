using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVEpisodeGroups;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class TVEpisodeGroupsProxy : ApiProxy
    {
        public TVEpisodeGroupsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<TVEpisodeGroupsResponse> GetAsync(TVEpisodeGroupsRequest request) =>
            Client.SendAsync<TVEpisodeGroupsResponse>(request);
    }
}