using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    public class MultiSearchRequest : SearchRequest
    {
        [ApiParameter(
            Name = "include_adult",
            ParameterType = ParameterType.Query)]
        public virtual bool IncludeAdult { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        /// pattern: ^[A-Z]{2}$
        /// </summary>
        [ApiParameter(
            Name = "region")]
        public virtual string Region { get; set; }
    }
}