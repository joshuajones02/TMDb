using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class TVEpisodeRating
    {
        [JsonProperty("value")]
        public virtual int Value { get; set; }
    }
}