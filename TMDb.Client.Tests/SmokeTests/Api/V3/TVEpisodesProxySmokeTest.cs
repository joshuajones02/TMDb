using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using TMDb.Client.Api.V3.Models.TVEpisodes;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class TVEpisodesProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish, "images,videos,translations")]
        public async Task<TVEpisodesDetailsResponse> TVEpisodesDetailsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language, string appendToResponse)
        {
            // Arrange
            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            // Assert
            Assert.IsType<TVEpisodesDetailsResponse>(response);

            return response;
        }

        [Theory]
        [InlineData((int)TV.TheTwilightZone2, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesAccountStatesSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            // Arrange
            var accountData = await GetAccountDataAsync();
            var sessionId = accountData.SessionId;

            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesAccountStatesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                SessionId = sessionId
            });

            // Assert
            Assert.IsType<TVEpisodesAccountStatesResponse>(response);
        }

        [Theory]
        [InlineData((int)TV.Ozark, 1, "2017-07-21", "2017-08-01")]
        public async Task TVEpisodesChangesSmokeTest(int tvId, int page, string startDate, string endDate)
        {
            // Arrange
            var tv = await Client.TVEpisodes.GetAsync(new TVEpisodesDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = 1,
                EpisodeNumber = 1
            });

            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesChangesRequest
            {
                EpisodeId = tv.Id,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            // Assert
            Assert.IsType<TVEpisodesChangesResponse>(response);
            Assert.True(response.Changes.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesCreditsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesCreditsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVEpisodesCreditsResponse>(response);
            Assert.True(response.Cast.Any()
                     || response.Crew.Any()
                     || response.GuestStars.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesExternalIdsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesExternalIdsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVEpisodesExternalIdsResponse>(response);
            Assert.True(response.TMDbId != null);
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesImagesSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesImagesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVEpisodesImagesResponse>(response);
            Assert.True(response.Stills.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesTranslationsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesTranslationsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVEpisodesTranslationsResponse>(response);
            Assert.True(response.Translations.Any());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesVideosSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            // Arrange
            // Act
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesVideosRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<TVEpisodesVideosResponse>(response);
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1)]
        public async Task RateTVEpisodeSmokeTest(int tvId, int seasonNumber, int epsiodeNumber)
        {
            // Arrange
            var createGuestSessionResponse = await Client.Authentication.GetAsync(new CreateGuestSessionRequest());
            var guestSessionId = createGuestSessionResponse.GuestSessionId;

            // Act
            var response = await Client.TVEpisodes.PostAsync(new RateTVEpisodeRequest
            {
                TvId = tvId,
                EpisodeNumber = epsiodeNumber,
                SeasonNumber = seasonNumber,
                GuestSessionId = guestSessionId,
                Rating = 10
            });

            // Assert
            Assert.IsType<RateTVEpisodeResponse>(response);

            // Cleanup
            await Client.TVEpisodes.DeleteAsync(new DeleteTVEpisodeRatingRequest
            {
                TvId = tvId,
                EpisodeNumber = epsiodeNumber,
                SeasonNumber = seasonNumber,
                GuestSessionId = guestSessionId,
            });
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1)]
        public async Task DeleteTVEpisodeRatingSmokeTest(int tvId, int seasonNumber, int epsiodeNumber)
        {
            // Arrange
            var createGuestSessionResponse = await Client.Authentication.GetAsync(new CreateGuestSessionRequest());
            var guestSessionId = createGuestSessionResponse.GuestSessionId;
            await Client.TVEpisodes.PostAsync(new RateTVEpisodeRequest
            {
                TvId = tvId,
                EpisodeNumber = epsiodeNumber,
                SeasonNumber = seasonNumber,
                GuestSessionId = guestSessionId,
                Rating = 10
            });

            // Act
            var response = await Client.TVEpisodes.DeleteAsync(new DeleteTVEpisodeRatingRequest
            {
                TvId = tvId,
                EpisodeNumber = epsiodeNumber,
                SeasonNumber = seasonNumber,
                GuestSessionId = guestSessionId,
            });

            // Assert
            Assert.IsType<DeleteTVEpisodeRatingResponse>(response);
        }
    }
}