using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Collections;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class CollectionsProxy : ApiProxy
    {
        public CollectionsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<CollectionDetailsResponse> GetAsync(CollectionDetailsRequest request) =>
            Client.SendAsync<CollectionDetailsResponse>(request);

        public virtual Task<CollectionImagesResponse> GetAsync(CollectionImagesRequest request) =>
            Client.SendAsync<CollectionImagesResponse>(request);

        public virtual Task<CollectionTranslationsResponse> GetAsync(CollectionTranslationsRequest request) =>
            Client.SendAsync<CollectionTranslationsResponse>(request);
    }
}