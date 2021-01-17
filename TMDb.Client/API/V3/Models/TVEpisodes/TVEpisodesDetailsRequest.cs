using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesDetailsRequest : TVEpisodesRequest
    {
        [ApiParameter(
            Name = "append_to_response",
            ParameterType = ParameterType.Query)]
        public virtual string AppendToResponse { get; set; }
    }
}