using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Find;
using TMDb.Client.Enums;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class FindProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData("tt1285016", Language.AmericanEnglish, ExternalSource.IMDbId)]
        public async Task FindByIdSmokeTest(string externalId, string language, ExternalSource externalSource)
        {
            var response = await Client.Find.GetAsync(new FindByIdRequest
            {
                ExternalId = externalId,
                LanguageAbbreviation = language,
                ExternalSource = externalSource
            });

            Assert.IsType<FindByIdResponse>(response);
            Assert.True(response.MovieResults.Any());
        }
    }
}