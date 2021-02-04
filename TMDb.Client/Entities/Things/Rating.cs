using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class Rating
    {
        [JsonProperty("value")]
        public virtual int Value { get; set; }
    }
}