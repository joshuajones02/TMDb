using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}")]
    public class TVSeasonsDetailsRequest : TVSeasonsRequest
    {
        [ApiParameter(
            Name = "append_to_response")]
        public virtual string AppendToResponse { get; set; }
    }
}