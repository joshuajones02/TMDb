using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Credits;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class CreditsProxySmokeTests : TestsClient
    {
        // TODO: Change this to fact and grab credit ids dynamically
        [Theory]
        [InlineData("52542282760ee313280017f9")]
        public async Task CreditsSmokeTest(string creditId)
        {
            var response = await Client.Credits.GetAsync(new CreditsRequest
            {
                CreditId = creditId
            });

            Assert.IsType<CreditsResponse>(response);
            Assert.True(response.Media != null);
            Assert.True(response.Person != null);
        }
    }
}