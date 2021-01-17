using Newtonsoft.Json;

namespace TMDb.Client.Entities
{
    public class Company
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}