using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Account
{
    public class MarkAsFavoriteResponse : TMDbStatusResponse
    {
        [JsonProperty("success")]
        public virtual bool Success { get; set; }
    }
}