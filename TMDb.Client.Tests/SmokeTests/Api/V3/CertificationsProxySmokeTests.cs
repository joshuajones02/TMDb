using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Certifications;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class CertificationsProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task MovieCertificationsSmokeTest()
        {
            var response = await Client.Certifications.GetAsync(new MovieCertificationsRequest());

            Assert.IsType<MovieCertificationsResponse>(response);
            Assert.True(response.Certifications != null);
            Assert.True(response.Certifications.US.Any());
        }

        [Fact]
        public async Task TVCertificationsSmokeTest()
        {
            var response = await Client.Certifications.GetAsync(new TVCertificationsRequest());

            Assert.IsType<TVCertificationsResponse>(response);
            Assert.True(response.Certifications != null);
            Assert.True(response.Certifications.US.Any());
        }
    }
}