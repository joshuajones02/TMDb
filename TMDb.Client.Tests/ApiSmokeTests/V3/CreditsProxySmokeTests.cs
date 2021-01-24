using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Credits;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class CreditsProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData("")]
        public async Task CreditsSmokeTest(string creditId)
        {
            throw new ArgumentException("Need credit ids (do this dynamically?)");

            var response = await Client.Credits.GetAsync(new CreditsRequest 
            {
                CreditId = creditId
            });

            Assert.Equal(typeof(CreditsResponse), response.GetType());
        }
    }
}