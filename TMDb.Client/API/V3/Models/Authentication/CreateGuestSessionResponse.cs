using Newtonsoft.Json;
using System;

namespace TMDb.Client.Api.V3.Models.Authentication
{
    public class CreateGuestSessionResponse : AuthenticationResponse
    {
        [JsonProperty("guest_session_id")]
        public virtual Guid? GuestSessionId { get; set; }
    }
}