using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Networks
{
    public abstract class NetworksBaseRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "network_id",
            ParameterType = ParameterType.Path)]
        public virtual int NetworkId { get; set; }
    }
}