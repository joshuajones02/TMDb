using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    public abstract class SearchRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "query",
            ParameterType = ParameterType.Query)]
        public virtual string Query { get; set; }
    }
}