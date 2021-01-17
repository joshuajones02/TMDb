using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Networks
{
    public class NetworkDetailsResponse
    {
        [JsonProperty("headquarters")]
        public string Headquarters { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("logo_path")]
        public string LogoPath { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("origin_country")]
        public string OriginCountry { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }
    }
}