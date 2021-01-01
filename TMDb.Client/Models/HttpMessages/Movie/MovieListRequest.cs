using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class MovieListRequest : TMDbRequest
    {
        public MovieListRequest() 
        { 
        }

        public MovieListRequest(int page) =>
            Page = page;

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}