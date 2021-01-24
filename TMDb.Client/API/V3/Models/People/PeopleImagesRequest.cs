using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/images")]
    public class PeopleImagesRequest : PeopleBaseRequest
    {
    }
}