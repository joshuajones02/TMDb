using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Keywords
{
    public class KeywordMovieRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "include_adult")]
        public bool IsAdult { get; set; }

        [JsonIgnore]
        [ApiParameter(
            Name = "keyword_id")]
        public int KeywordId { get; set; }

        [ApiParameter(
            Name = "language")]
        public string Language { get; set; }
    }
}