using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Changes
{
    [ApiGetEndpoint("/tv/changes")]
    public class TVChangeListRequest : ChangeListRequest
    {
    }
}