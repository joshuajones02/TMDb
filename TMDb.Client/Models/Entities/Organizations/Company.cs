using Newtonsoft.Json;

namespace TMDb.Client.Entities.Organizations
{
    public class Company
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("logo_path")]
        public virtual string LogoPath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}