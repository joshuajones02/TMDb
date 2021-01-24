using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Keywords;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class KeywordsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData(0)]
        public async Task KeywordDetailsSmokeTest(int keywordId)
        {
            throw new NotImplementedException("Need keyword ids");

            var response = await Client.Keywords.GetAsync(new KeywordDetailsRequest
            {
                KeywordId = keywordId
            });

            Assert.Equal(typeof(KeywordDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData(0, Language.AmericanEnglish, null)]
        [InlineData(0, Language.CanadianFrench,  null)]
        [InlineData(0, Language.Chinese,         null)]
        [InlineData(0, Language.German,          null)]
        [InlineData(0, Language.Italian,         null)]
        public async Task KeywordMovieSmokeTest(int keywordId, string language, bool? isAdult)
        {
            throw new NotImplementedException("Need keyword ids");

            var response = await Client.Keywords.GetAsync(new KeywordMovieRequest
            {
                KeywordId = keywordId,
                LanguageAbbreviation = language,
                IsAdult = isAdult
            });

            Assert.Equal(typeof(KeywordMovieResponse), response.GetType());
        }
    }
}