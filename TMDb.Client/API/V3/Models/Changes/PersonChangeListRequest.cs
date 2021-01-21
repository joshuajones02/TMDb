using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Changes
{
    [ApiGetEndpoint("/person/changes")]
    public class PersonChangeListRequest : ChangeListRequest
    {
    }
}