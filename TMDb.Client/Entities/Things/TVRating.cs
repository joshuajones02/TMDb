using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class TVRating
    {
        [JsonProperty("value")]
        public virtual int Value { get; set; }
    }
}