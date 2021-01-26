using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Search
{
    public abstract class SearchRequest : TMDbRequest
    {
        public SearchRequest()
        {
            Page = 1;
        }

        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "query",
            ParameterType = ParameterType.Query)]
        public virtual string Query { get; set; }
    }
}