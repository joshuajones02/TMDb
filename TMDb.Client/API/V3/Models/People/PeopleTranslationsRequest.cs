using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/translations")]
    public class PeopleTranslationsRequest : PeopleRequest
    {
    }
}