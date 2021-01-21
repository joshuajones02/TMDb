using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}/screened_theatrically")]
    public class TVScreenedTheatricallyRequest : TVBaseRequest
    {
    }
}