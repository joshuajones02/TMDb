using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Keywords;
using TMDb.Client.Api.V3.Models.Lists;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class ListsProxy : ApiProxy
    {
        public ListsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<ListDetailsResponse> GetAsync(ListDetailsRequest request) =>
            Client.SendAsync<ListDetailsResponse>(request);

        public virtual Task<ListItemStatusResponse> GetAsync(ListItemStatusRequest request) =>
            Client.SendAsync<ListItemStatusResponse>(request);
        
        public virtual Task<CreateListResponse> PostAsync(CreateListRequest request) =>
            Client.SendAsync<CreateListResponse>(request);

        public virtual Task<ListAddMovieResponse> PostAsync(ListAddMovieRequest request) =>
            Client.SendAsync<ListAddMovieResponse>(request);

        public virtual Task<ClearListResponse> PostAsync(ClearListRequest request) =>
            Client.SendAsync<ClearListResponse>(request);

        public virtual Task<DeleteListResponse> DeleteAsync(DeleteListRequest request) =>
            Client.SendAsync<DeleteListResponse>(request);
    }
}