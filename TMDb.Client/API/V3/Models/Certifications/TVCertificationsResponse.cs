using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Certifications
{
    public class TVCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public Certifications Certifications { get; set; }
    }
}