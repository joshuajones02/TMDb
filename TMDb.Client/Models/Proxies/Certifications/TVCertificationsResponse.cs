using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Certifications
{
    public class TVCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public Certifications Certifications { get; set; }
    }
}