﻿using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Authentication
{
    public class CreateRequestTokenResponse : AuthenticationResponse
    {
        [JsonProperty("request_token")]
        public virtual string RequestToken { get; set; }
    }
}