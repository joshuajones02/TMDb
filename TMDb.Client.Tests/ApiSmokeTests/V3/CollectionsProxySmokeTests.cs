using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Collections;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class CollectionsProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData(Language.AmericanEnglish)]
        [InlineData(Language.BritishEnglish )]
        [InlineData(Language.CanadianFrench )]
        [InlineData(Language.Chinese        )]
        [InlineData(Language.FinlandSwedish )]
        [InlineData(Language.German         )]
        [InlineData(Language.Italian        )]
        [InlineData(Language.MexicanSpanish )]
        public async Task CollectionDetailsSmokeTest(string language)
        {
            var response = await Client.Collections.GetAsync(new CollectionDetailsRequest
            {
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(CollectionDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        [InlineData(Language.BritishEnglish )]
        [InlineData(Language.CanadianFrench )]
        [InlineData(Language.Chinese        )]
        [InlineData(Language.FinlandSwedish )]
        [InlineData(Language.German         )]
        [InlineData(Language.Italian        )]
        [InlineData(Language.MexicanSpanish )]
        public async Task CollectionImagesSmokeTest(string language)
        {
            var response = await Client.Collections.GetAsync(new CollectionImagesRequest
            {
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(CollectionImagesResponse), response.GetType());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        [InlineData(Language.BritishEnglish )]
        [InlineData(Language.CanadianFrench )]
        [InlineData(Language.Chinese        )]
        [InlineData(Language.FinlandSwedish )]
        [InlineData(Language.German         )]
        [InlineData(Language.Italian        )]
        [InlineData(Language.MexicanSpanish )]
        public async Task CollectionTranslationsSmokeTest(string language)
        {
            var response = await Client.Collections.GetAsync(new CollectionTranslationsRequest
            {
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(CollectionTranslationsResponse), response.GetType());
        }
    }
}