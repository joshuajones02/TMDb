using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Collections;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
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

            Assert.Equal(typeof(CollectionDetailsResponse), response.GetType());
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

            Assert.Equal(typeof(CollectionImagesResponse), response.GetType());
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

            Assert.Equal(typeof(CollectionTranslationsResponse), response.GetType());
        }
    }
}