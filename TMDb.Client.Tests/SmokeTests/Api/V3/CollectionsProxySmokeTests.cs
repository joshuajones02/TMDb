using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Collections;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class CollectionsProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData((int)Collection.TheHungerGames, Language.AmericanEnglish)]
        [InlineData((int)Collection.TheHungerGames, Language.BritishEnglish )]
        [InlineData((int)Collection.TheHungerGames, Language.CanadianFrench )]
        [InlineData((int)Collection.TheHungerGames, Language.Chinese        )]
        [InlineData((int)Collection.TheHungerGames, Language.FinlandSwedish )]
        [InlineData((int)Collection.TheHungerGames, Language.German         )]
        [InlineData((int)Collection.TheHungerGames, Language.Italian        )]
        [InlineData((int)Collection.TheHungerGames, Language.MexicanSpanish )]
        public async Task CollectionDetailsSmokeTest(int collectionId, string language)
        {
            var response = await Client.Collections.GetAsync(new CollectionDetailsRequest
            {
                CollectionId = collectionId,
                LanguageAbbreviation = language
            });

            Assert.IsType<CollectionDetailsResponse>(response);
            Assert.True(response.Parts.Any());
        }

        [Theory]
        [InlineData((int)Collection.TheHungerGames, Language.AmericanEnglish)]
        [InlineData((int)Collection.TheHungerGames, Language.BritishEnglish )]
        [InlineData((int)Collection.TheHungerGames, Language.CanadianFrench )]
        [InlineData((int)Collection.TheHungerGames, Language.Chinese        )]
        [InlineData((int)Collection.TheHungerGames, Language.FinlandSwedish )]
        [InlineData((int)Collection.TheHungerGames, Language.German         )]
        [InlineData((int)Collection.TheHungerGames, Language.Italian        )]
        [InlineData((int)Collection.TheHungerGames, Language.MexicanSpanish )]
        public async Task CollectionImagesSmokeTest(int collectionId, string language)
        {
            var response = await Client.Collections.GetAsync(new CollectionImagesRequest
            {
                CollectionId = collectionId,
                LanguageAbbreviation = language
            });

            Assert.IsType<CollectionImagesResponse>(response);
            Assert.True(response.Backdrops.Any());
            Assert.True(response.Posters.Any());
        }

        [Theory]
        [InlineData((int)Collection.TheHungerGames, Language.AmericanEnglish)]
        [InlineData((int)Collection.TheHungerGames, Language.BritishEnglish )]
        [InlineData((int)Collection.TheHungerGames, Language.CanadianFrench )]
        [InlineData((int)Collection.TheHungerGames, Language.Chinese        )]
        [InlineData((int)Collection.TheHungerGames, Language.FinlandSwedish )]
        [InlineData((int)Collection.TheHungerGames, Language.German         )]
        [InlineData((int)Collection.TheHungerGames, Language.Italian        )]
        [InlineData((int)Collection.TheHungerGames, Language.MexicanSpanish )]
        public async Task CollectionTranslationsSmokeTest(int collectionId, string language)
        {
            var response = await Client.Collections.GetAsync(new CollectionTranslationsRequest
            {
                CollectionId = collectionId,
                LanguageAbbreviation = language
            });

            Assert.IsType<CollectionTranslationsResponse>(response);
            Assert.True(response.Translations.Any());
        }
    }
}