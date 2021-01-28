using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}/images")]
    public class NetworkImagesRequest : NetworksBaseRequest
    {
    }
}