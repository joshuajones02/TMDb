using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Certifications
{
    public class MovieCertificationsResponse : TMDbResponse
    {
        [JsonProperty("certifications")]
        public virtual MovieCertifications Certifications { get; set; }
    }
}