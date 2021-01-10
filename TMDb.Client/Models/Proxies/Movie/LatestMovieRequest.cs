using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class LatestMovieRequest : TMDbRequest
    {
        [JsonProperty("language")]
        public string LanguageAbbreviation { get; set; }
    }
}