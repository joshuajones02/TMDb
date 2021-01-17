using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.TVEpisodeGroups;
using TMDb.Client.API.V3.Models.TVEpisodes;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class TVEpisodeGroupsProxy : ApiProxy
    {
        public TVEpisodeGroupsProxy(TMDbClient client) : base(client)
        {
        }

        public string FormatPath(string path, int id) => string.Format(path, id);

        public Task<TVEpisodesDetailsResponse> GetAsync(TVEpisodeGroupsRequest request) =>
            Client.GetAsync<TVEpisodesDetailsResponse>(
                Serialize(FormatPath("/tv/episode_group/{id}", request.Id), request));
    }
}