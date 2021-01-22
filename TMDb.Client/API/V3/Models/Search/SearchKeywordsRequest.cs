using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Search
{
    [ApiGetEndpoint("/search/keyword")]
    public class SearchKeywordsRequest : SearchRequest
    {
    }
}