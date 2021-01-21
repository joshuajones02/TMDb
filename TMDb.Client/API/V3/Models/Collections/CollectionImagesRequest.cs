using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Collections
{
    [ApiGetEndpoint("/collection/{collection_id}/images")]
    public class CollectionImagesRequest : CollectionRequest
    {
    }
}