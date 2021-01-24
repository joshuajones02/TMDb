using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Certifications;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class CertificationsProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task MovieCertificationsSmokeTest()
        {
            var response = await Client.Certifications.GetAsync(new MovieCertificationsRequest());

            Assert.Equal(typeof(TVCertificationsResponse), response.GetType());
        }

        [Fact]
        public async Task TVCertificationsSmokeTest()
        {
            var response = await Client.Certifications.GetAsync(new TVCertificationsRequest());

            Assert.Equal(typeof(TVCertificationsResponse), response.GetType());
        }
    }
}