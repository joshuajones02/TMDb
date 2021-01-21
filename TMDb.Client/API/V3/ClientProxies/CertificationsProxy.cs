using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Certifications;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class CertificationsProxy : ApiProxy
    {
        public CertificationsProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<MovieCertificationsResponse> GetAsync(MovieCertificationsRequest request) =>
            Client.SendAsync<MovieCertificationsResponse>(request);

        public virtual Task<TVCertificationsResponse> GetAsync(TVCertificationsRequest request) =>
            Client.SendAsync<TVCertificationsResponse>(request);
    }
}