using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Networks
{
    [ApiGetEndpoint("/network/{network_id}/alternative_names")]
    public class NetworkAlternativeNameRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "network_id",
            ParameterType = ParameterType.Path)]
        public virtual int NetworkId { get; set; }
    }
}