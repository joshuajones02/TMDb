using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Changes
{
    [ApiGetEndpoint("/movie/changes")]
    public class MovieChangeListRequest : ChangeListRequest
    {
    }
}