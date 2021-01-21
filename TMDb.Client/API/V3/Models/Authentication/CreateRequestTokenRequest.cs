using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Authentication
{
    [ApiGetEndpoint("/authentication/token/new")]
    public class CreateRequestTokenRequest : TMDbRequest
    {
    }
}