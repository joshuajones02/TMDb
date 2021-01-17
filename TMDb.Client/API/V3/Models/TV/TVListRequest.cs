using Newtonsoft.Json;
using TMDb.Client.Attributes;

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
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}