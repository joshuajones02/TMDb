using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Certifications
{
    public class MovieCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public virtual MovieCertifications Certifications { get; set; }
    }
}