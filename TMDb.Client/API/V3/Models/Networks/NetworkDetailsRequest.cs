using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}")]
    public class NetworkDetailsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "network_id",
            ParameterType = ParameterType.Path)]
        public virtual int NetworkId { get; set; }
    }
}