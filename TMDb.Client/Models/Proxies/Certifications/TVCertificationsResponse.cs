using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.Models.Proxies.Certifications
{
    public class TVCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public Certifications Certifications { get; set; }
    }
}