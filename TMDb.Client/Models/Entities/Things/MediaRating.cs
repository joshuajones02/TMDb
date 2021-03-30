using Newtonsoft.Json;
using TMDb.Client.Contracts;

namespace TMDb.Client.Entities.Things
{
    public class MediaRating : IRatingResponse
    {
        [JsonProperty("value")]
        public virtual double? Rating { get; set; }
    }
}