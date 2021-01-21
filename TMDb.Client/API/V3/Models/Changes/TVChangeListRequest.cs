using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Changes
{
    [ApiGetEndpoint("/tv/changes")]
    public class TVChangeListRequest : ChangeListRequest
    {
    }
}