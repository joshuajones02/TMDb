using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Genres;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class GenresProxy : ApiProxy
    {
        public GenresProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<GenresResponse> ListMovieGenres(GenresRequest request) =>
            Client.GetAsync<GenresResponse>(Serialize("/genre/movie/list", request));

        public virtual Task<GenresResponse> TV(GenresRequest request) =>
            Client.GetAsync<GenresResponse>(Serialize("/genre/tv/list", request));
    }
}