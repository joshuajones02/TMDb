using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsDetailsRequest : TVSeasonsRequest
    {
        [ApiParameter(
            Name = "append_to_response")]
        public virtual string AppendToResponse { get; set; }
    }
}