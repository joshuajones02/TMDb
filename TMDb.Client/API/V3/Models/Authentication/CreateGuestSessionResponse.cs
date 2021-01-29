using Newtonsoft.Json;
using System;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.Authentication
{
    public class CreateGuestSessionResponse : AuthenticationResponse, IGuestSession
    {
        [JsonProperty("guest_session_id")]
        public virtual Guid? GuestSessionId { get; set; }
    }
}