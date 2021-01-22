using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Authentication
{
    public class DeleteSessionResponse : TMDbResponse
    {
        [JsonProperty("success")]
        public virtual bool IsSuccess { get; set; }
    }
}