using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.Models.Proxies.Certifications
{
    public class MovieCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public virtual MovieCertifications Certifications { get; set; }
    }
}
