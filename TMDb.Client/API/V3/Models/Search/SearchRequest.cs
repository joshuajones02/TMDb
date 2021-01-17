using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public int Page { get; set; }

        [ApiParameter(
            Name = "query")]
        [JsonRequired]
        public string Query { get; set; }
    }
}