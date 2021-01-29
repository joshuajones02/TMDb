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
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish, "")]
        public async Task<TVEpisodesDetailsResponse> TVEpisodesDetailsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language, string appendToResponse)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            Assert.IsType<TVEpisodesDetailsResponse>(response);

            return response;
        }

        // TODO: Get Setup GuestSessionId & SessionId
        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesAccountStatesSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            //var guestSessionId = "";
            //var sessionId = "";

            //var response = await Client.TVEpisodes.GetAsync(new TVEpisodesAccountStatesRequest
            //{
            //    TvId = tvId,
            //    SeasonNumber = seasonNumber,
            //    EpisodeNumber = epsiodeNumber,
            //    LanguageAbbreviation = language,
            //    GuestSessionId = guestSessionId,
            //    SessionId = sessionId
            //});

            //Assert.IsType<TVEpisodesAccountStatesResponse>(response);
        }

        [Theory]
        //[InlineData((int)TV.BlackMirror,        1, "2020-12-12", "2020-12-24")]
        //[InlineData((int)TV.Dateline,           1, "2020-03-01", "2020-03-14")]
        //[InlineData((int)TV.Dexter,             1, "2016-07-17", "2016-07-30")]
        //[InlineData((int)TV.FortyEightHours,    1, "2018-09-01", "2018-09-14")]    
        //[InlineData((int)TV.LetterKenny,        1, "2020-02-20", "2017-03-01")]
        //[InlineData((int)TV.MindHunter,         1, "2019-11-10", "2019-11-23")]
        //[InlineData((int)TV.ModernFamily,       1, "2020-12-12", "2020-12-24")]
        //[InlineData((int)TV.Ozark,              1, "2020-03-01", "2020-03-14")]
        //[InlineData((int)TV.ParksAndRecreation, 1, "2016-07-17", "2016-07-30")]
        //[InlineData((int)TV.RickAndMorty,       1, "2018-09-01", "2018-09-14")]
        //[InlineData((int)TV.Shameless,          1, "2020-02-20", "2017-03-01")]
        //[InlineData((int)TV.SouthPark,          1, "2019-11-10", "2019-11-23")]
        //[InlineData((int)TV.StrangerThings,     1, "2019-11-10", "2019-11-23")]
        //[InlineData((int)TV.TheOffice,          1, "2020-12-01", "2020-12-14")]
        //[InlineData((int)TV.TheTwilightZone,    1, "2020-12-15", "2020-12-28")]
        //[InlineData((int)TV.TheTwilightZone2,   1, "2020-12-29", "2021-01-10")]
        //[InlineData((int)TV.TwentyTwenty,       1, "2021-01-11", "2021-01-23")]
        //[InlineData((int)TV.GameOfThrones,      1, "2019-12-01", "2019-12-14")]
        //[InlineData((int)TV.GameOfThrones,      1, "2019-12-15", "2019-12-28")]
        //[InlineData((int)TV.GameOfThrones,      1, "2019-12-29", "2019-01-10")]
        [InlineData((int)TV.GameOfThrones, 1, "2020-01-11", "2020-01-23")]
        public async Task TVEpisodesChangesSmokeTest(int tvId, int page, string startDate, string endDate)
        {
            var tv = await Client.TVEpisodes.GetAsync(new TVEpisodesDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = 1,
                EpisodeNumber = 1
            });

            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesChangesRequest
            {
                EpisodeId = tv.Id,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            Assert.IsType<TVEpisodesChangesResponse>(response);
            Assert.True(response.Changes.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesCreditsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesCreditsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVEpisodesCreditsResponse>(response);
            Assert.True(response.Cast.Any());
            Assert.True(response.Crew.Any());
            Assert.True(response.GuestStars.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesExternalIdsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesExternalIdsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVEpisodesExternalIdsResponse>(response);
            Assert.True(response.TMDbId != null);
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesImagesSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesImagesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVEpisodesImagesResponse>(response);
            Assert.True(response.Stills.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesTranslationsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesTranslationsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVEpisodesTranslationsResponse>(response);
            Assert.True(response.Translations.Any());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesVideosSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesVideosRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVEpisodesVideosResponse>(response);
            Assert.True(response.Videos.Any());
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