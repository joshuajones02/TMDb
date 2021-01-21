using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Genres;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class GenresProxy : ApiProxy
    {
        public GenresProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<MovieGenresResponse> GetAsync(MovieGenresRequest request) =>
            Client.SendAsync<MovieGenresResponse>(request);

        public virtual Task<TVGenresResponse> GetAsync(TVGenresRequest request) =>
            Client.SendAsync<TVGenresResponse>(request);
    }
}