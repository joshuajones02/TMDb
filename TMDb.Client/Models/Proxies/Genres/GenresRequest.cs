using Newtonsoft.Json;

namespace TMDb.Client.Models.HttpMessages.Genres
{
    public class GenresRequest : TMDbRequest
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }
}