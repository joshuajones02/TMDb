using Newtonsoft.Json;

namespace TMDb.Client.Contracts
{
    public interface IRatingResponse
    {
        [JsonProperty("value")]
        double? Rating { get; set; }
    }
}