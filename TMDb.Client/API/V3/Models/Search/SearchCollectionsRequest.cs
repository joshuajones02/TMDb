using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchCollectionsRequest : SearchRequest
    {
        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}