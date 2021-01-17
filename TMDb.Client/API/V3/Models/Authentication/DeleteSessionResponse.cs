using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class DeleteSessionResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
    }
}