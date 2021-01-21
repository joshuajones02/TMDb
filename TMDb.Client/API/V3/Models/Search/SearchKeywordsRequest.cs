using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    [ApiGetEndpoint("/search/keyword")]
    public class SearchKeywordsRequest : SearchRequest
    {
    }
}