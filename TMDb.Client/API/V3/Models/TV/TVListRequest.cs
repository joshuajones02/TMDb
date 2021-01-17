using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVListRequest : TMDbRequest
    {
        public TVListRequest()
        {
        }

        public TVListRequest(int page) =>
            Page = page;

        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public int Page { get; set; }

        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }
    }
}