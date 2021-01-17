using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchCollectionsRequest : SearchRequest
    {
        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }
    }
}