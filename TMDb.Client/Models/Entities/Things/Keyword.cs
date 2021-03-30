using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class Keyword
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}