using Newtonsoft.Json;

namespace TMDb.Client.Entities
{
    public class MovieGenre
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}