using System.Threading.Tasks;
using TMDb.Client.Models.Proxies.Certifications;

namespace TMDb.Client.Proxies
{
    public class CertificationsProxy : ProxyBase
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