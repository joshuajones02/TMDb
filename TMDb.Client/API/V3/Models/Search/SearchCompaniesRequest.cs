using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Search
{
    [ApiGetEndpoint("/search/company")]
    public class SearchCompaniesRequest : SearchRequest
    {
    }
}