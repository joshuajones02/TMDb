using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Certifications;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class CertificationsProxy : ApiProxy
    {
        public CertificationsProxy(TMDbClient client) : base(client)
        {
        }

        public Task<MovieCertificationsResponse> GetAsync(MovieCertificationsRequest request) =>
            Client.GetAsync<MovieCertificationsResponse>(Serialize("/certification/movie/list", request));

        public Task<TVCertificationsResponse> GetAsync(TVCertificationsRequest request) =>
            Client.GetAsync<TVCertificationsResponse>(Serialize("/certification/tv/list", request));
    }
}