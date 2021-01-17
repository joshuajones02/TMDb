using Newtonsoft.Json;

namespace TMDb.Client.Entities.Items
{
    public class Genre
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}