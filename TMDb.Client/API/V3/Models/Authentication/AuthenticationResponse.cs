using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Authentication
{
    [Obsolete("Revisit when TMDbResponse is refactored")]
    public class AuthenticationResponse
    {
        [JsonProperty("success")]
        public virtual bool IsSuccess { get; set; }

        [JsonProperty("expires_at")]
        public DateTime? Expiration { get; set; }
    }
}