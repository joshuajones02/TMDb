using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVSeasons;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class TVSeasonsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)TV.BlackMirror, 1, Language.AmericanEnglish, "images")]
        [InlineData((int)TV.GameOfThrones, 1, Language.AmericanEnglish, "videos")]
        public async Task TVSeasonsDetailsSmokeTest(int tvId, int seasonNumber, string language, string appendToResponse)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            // Assert
            Assert.IsType<TVSeasonsDetailsResponse>(response);
        }

        // TODO: Review response object is being serialized correctly 
        [Theory]
        [InlineData((int)TV.GameOfThrones, 1, Language.AmericanEnglish)]
        public async Task TVSeasonsAccountStatesSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsAccountStatesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language,
                SessionId = sessionId
            });

            // Assert
            Assert.IsType<TVSeasonsAccountStatesResponse>(response);
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.LetterKenny,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.MindHunter,         1, Language.AmericanEnglish)]
        [InlineData((int)TV.ModernFamily,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Ozark,              1, Language.AmericanEnglish)]
        [InlineData((int)TV.ParksAndRecreation, 1, Language.AmericanEnglish)]
        [InlineData((int)TV.RickAndMorty,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.StrangerThings,     1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone2,   1, Language.AmericanEnglish)]
        [InlineData((int)TV.TwentyTwenty,       1, Language.AmericanEnglish)]
        public async Task TVSeasonsAggregateCreditsSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsAggregateCreditsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVSeasonsAggregateCreditsResponse>(response);
            Assert.True(response.Cast.Any() || response.Crew.Any());
        }

        [Theory]
        [InlineData((int)TV.Ozark,              1, "2017-07-21", "2017-08-01")]
        public async Task TVSeasonsChangesSmokeTest(int tvId, int page, string startDate, string endDate)
        {
            // Arrange
            var seasonDetails = await Client.TVSeasons.GetAsync(new TVSeasonsDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = 1,
            });
            
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsChangesRequest
            {
                SeasonId = seasonDetails.Id,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            // Assert
            Assert.IsType<TVSeasonsChangesResponse>(response);
            Assert.True(response.Changes.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.LetterKenny,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.MindHunter,         1, Language.AmericanEnglish)]
        [InlineData((int)TV.ModernFamily,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Ozark,              1, Language.AmericanEnglish)]
        [InlineData((int)TV.ParksAndRecreation, 1, Language.AmericanEnglish)]
        [InlineData((int)TV.RickAndMorty,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.StrangerThings,     1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone,    1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone2,   1, Language.AmericanEnglish)]
        [InlineData((int)TV.TwentyTwenty,       1, Language.AmericanEnglish)]
        public async Task TVSeasonsCreditsSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsCreditsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVSeasonsCreditsResponse>(response);
            Assert.True(response.Cast.Any() || response.Crew.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.LetterKenny,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.MindHunter,         1, Language.AmericanEnglish)]
        [InlineData((int)TV.ModernFamily,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Ozark,              1, Language.AmericanEnglish)]
        [InlineData((int)TV.ParksAndRecreation, 1, Language.AmericanEnglish)]
        [InlineData((int)TV.RickAndMorty,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.StrangerThings,     1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone,    1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone2,   1, Language.AmericanEnglish)]
        [InlineData((int)TV.TwentyTwenty,       1, Language.AmericanEnglish)]
        public async Task TVSeasonsExternalIdsSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsExternalIdsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVSeasonsExternalIdsResponse>(response);
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.LetterKenny,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.MindHunter,         1, Language.AmericanEnglish)]
        [InlineData((int)TV.ModernFamily,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Ozark,              1, Language.AmericanEnglish)]
        [InlineData((int)TV.ParksAndRecreation, 1, Language.AmericanEnglish)]
        [InlineData((int)TV.RickAndMorty,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.StrangerThings,     1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone,    1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone2,   1, Language.AmericanEnglish)]
        [InlineData((int)TV.TwentyTwenty,       1, Language.AmericanEnglish)]
        public async Task TVSeasonsImagesSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsImagesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVSeasonsImagesResponse>(response);
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.LetterKenny,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.MindHunter,         1, Language.AmericanEnglish)]
        [InlineData((int)TV.ModernFamily,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Ozark,              1, Language.AmericanEnglish)]
        [InlineData((int)TV.ParksAndRecreation, 1, Language.AmericanEnglish)]
        [InlineData((int)TV.RickAndMorty,       1, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.StrangerThings,     1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,          1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone,    1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheTwilightZone2,   1, Language.AmericanEnglish)]
        [InlineData((int)TV.TwentyTwenty,       1, Language.AmericanEnglish)]
        public async Task TVSeasonsTranslationsSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsTranslationsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVSeasonsTranslationsResponse>(response);
            Assert.True(response.Translations.Any());
        }

        [Theory]
        [InlineData((int)TV.StrangerThings, 1, Language.AmericanEnglish)]
        public async Task TVSeasonsVideosSmokeTest(int tvId, int seasonNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsVideosRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVSeasonsVideosResponse>(response);
            Assert.True(response.Videos.Any());
        }
    }
}