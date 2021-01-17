using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Authentication
{
    [Obsolete("Revisit when TMDbResponse is refactored")]
    public class CreateSessionResponse
    {
        [JsonProperty("success")]
        public virtual bool IsSuccess { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }
}