using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    [ApiGetEndpoint("/search/company")]
    public class SearchCompaniesRequest : SearchRequest
    {
    }
}