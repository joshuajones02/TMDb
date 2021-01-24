using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Find;
using TMDb.Client.Enums;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class FindProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData("", "", ExternalSource.IMDbId)]
        public async Task FindByIdSmokeTest(string externalId, string language, ExternalSource externalSource)
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