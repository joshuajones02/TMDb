using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesDetailsRequest : TVEpisodesRequest
    {
        [ApiParameter(
            Name = "append_to_response")]
        public virtual string AppendToResponse { get; set; }
    }
}