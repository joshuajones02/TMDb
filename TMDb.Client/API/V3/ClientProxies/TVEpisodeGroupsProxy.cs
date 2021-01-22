using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVEpisodeGroups;
using TMDb.Client.Api.V3.Models.TVEpisodes;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class TVEpisodeGroupsProxy : ApiProxy
    {
        public TVEpisodeGroupsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<TVEpisodesDetailsResponse> GetAsync(TVEpisodeGroupsRequest request) =>
            Client.SendAsync<TVEpisodesDetailsResponse>(request);
    }
}