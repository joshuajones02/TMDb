using Newtonsoft.Json;

namespace TMDb.Client.Models
{
    public class TVGenre
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
