using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Keywords;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class KeywordsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)Keyword.PsychologicalThriller)]
        [InlineData((int)Keyword.Thriller             )]
        [InlineData((int)Keyword.TrueCrime            )]
        public async Task KeywordDetailsSmokeTest(int keywordId)
        {
            var response = await Client.Keywords.GetAsync(new KeywordDetailsRequest
            {
                KeywordId = keywordId
            });

            Assert.IsType<KeywordDetailsResponse>(response);
        }

        [Theory]
        [InlineData((int)Keyword.PsychologicalThriller, Language.AmericanEnglish, null)]
        [InlineData((int)Keyword.Thriller,              Language.CanadianFrench,  null)]
        [InlineData((int)Keyword.TrueCrime,             Language.Italian,         null)]
        public async Task KeywordMovieSmokeTest(int keywordId, string language, bool? isAdult)
        {
            var response = await Client.Keywords.GetAsync(new KeywordMovieRequest
            {
                KeywordId = keywordId,
                LanguageAbbreviation = language,
                IsAdult = isAdult
            });

            Assert.IsType<KeywordMovieResponse>(response);
            Assert.True(response.Results.Any());
        }
    }
}