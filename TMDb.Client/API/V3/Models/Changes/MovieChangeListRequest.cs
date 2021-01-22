using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Changes
{
    [ApiGetEndpoint("/movie/changes")]
    public class MovieChangeListRequest : ChangeListRequest
    {
    }
}