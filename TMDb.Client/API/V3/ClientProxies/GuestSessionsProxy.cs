using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.GuestSessionRated;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class GuestSessionsProxy : ApiProxy
    {
        public GuestSessionsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual string FormatPath(string path, string id) => string.Format(path, id);

        public virtual Task<GuestSessionRatedMoviesResponse> GetAsync(GuestSessionRatedMoviesRequest request) =>
            Client.GetAsync<GuestSessionRatedMoviesResponse>(
                Serialize(FormatPath("/guest_session/{0}/rated/movies", request.GuestSessionId), request));

        public virtual Task<GuestSessionRatedMoviesResponse> GetAsync(GuestSessionRatedTVRequest request) =>
            Client.GetAsync<GuestSessionRatedMoviesResponse>(
                Serialize(FormatPath("/guest_session/{0}/rated/tv", request.GuestSessionId), request));

        public virtual Task<GuestSessionRatedTVEpisodesResponse> GetAsync(GuestSessionRatedTVEpisodesRequest request) =>
            Client.GetAsync<GuestSessionRatedTVEpisodesResponse>(
                Serialize(FormatPath("/guest_session/{0}/rated/tv/episodes", request.GuestSessionId), request));
    }
}