using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class MovieDetailsListRequest : TMDbRequest
    {
        public MovieDetailsListRequest() 
        { 
        }

        public MovieDetailsListRequest(int page) =>
            Page = page;

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}