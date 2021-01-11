using System.Threading.Tasks;
using TMDb.Client.Models.HttpMessages.Genres;

namespace TMDb.Client.Proxies
{
    public class GenresProxy : ProxyBase
    {
        public GenresProxy(TMDbClient client) : base(client)
        {
        }

        public Task<GenresResponse> ListMovieGenres(GenresRequest request) =>
            Client.GetAsync<GenresResponse>(Serialize("/genre/movie/list", request));

        public Task<GenresResponse> TV(GenresRequest request) =>
            Client.GetAsync<GenresResponse>(Serialize("/genre/tv/list", request));
    }
}
