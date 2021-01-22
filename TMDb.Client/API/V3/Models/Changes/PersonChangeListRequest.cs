using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Changes
{
    [ApiGetEndpoint("/person/changes")]
    public class PersonChangeListRequest : ChangeListRequest
    {
    }
}