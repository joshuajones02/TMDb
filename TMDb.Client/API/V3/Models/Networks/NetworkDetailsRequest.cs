using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}")]
    public class NetworkDetailsRequest : NetworksBaseRequest
    {
    }
}