using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using TMDb.Client.Api.V3.Models.Find;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class FindProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData("", "", "")]
        public async Task FindByIdSmokeTest(string externalId, string language, string externalSource)
        {
            throw new NotImplementedException("Insert inline data parameters");

            var response = await Client.Find.GetAsync(new FindByIdRequest
            {
                ExternalId = externalId,
                LanguageAbbreviation = language,
                ExternalSource = externalSource
            });

            Assert.Equal(typeof(FindByIdResponse), response.GetType());
        }
    }
}