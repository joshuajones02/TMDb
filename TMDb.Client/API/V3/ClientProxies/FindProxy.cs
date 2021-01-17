using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Find;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class FindProxy : ApiProxy
    {
        public FindProxy(TMDbClient client) : base(client)
        {
        }

        public string FormatPath(string path, int id) => string.Format(path, id);

        public Task<FindByIdResponse> GetAsync(FindByIdRequest request) =>
            Client.GetAsync<FindByIdResponse>(Serialize("/find/{external_id}", request));
    }
}