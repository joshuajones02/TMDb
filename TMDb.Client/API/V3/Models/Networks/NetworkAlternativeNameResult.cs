﻿using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Networks
{
    public class NetworkAlternativeNameResult
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}