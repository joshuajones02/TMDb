using System;
using System.Threading.Tasks;
using TMDb.Client.Models.Proxies.Collections;

namespace TMDb.Client.Proxies
{
    public class CollectionsProxy : ProxyBase
    {
        public CollectionsProxy(TMDbClient client) : base(client)
        {
        }

        [Obsolete("// TODO: Implement string.Format path attribute logic")]
        public Task<CollectionDetailsResponse> GetAsync(CollectionDetailsRequest request) =>
            Client.GetAsync<CollectionDetailsResponse>(Serialize("/collection/{collection_id}", request));

        public Task<CollectionImagesResponse> GetAsync(CollectionImagesRequest request) =>
            Client.GetAsync<CollectionImagesResponse>(Serialize("/collection/{collection_id}/images", request));

        public Task<CollectionTranslationsResponse> GetAsync(CollectionTranslationsRequest request) =>
            Client.GetAsync<CollectionTranslationsResponse>(Serialize("/collection/{collection_id}/translations", request));
    }
}