using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Keywords
{
    public class KeywordDetailsRequest : TMDbRequest
    {
        [JsonIgnore]
        [ApiParameter(
            Name = "keyword_id")]
        public int KeywordId { get; set; }
    }
}