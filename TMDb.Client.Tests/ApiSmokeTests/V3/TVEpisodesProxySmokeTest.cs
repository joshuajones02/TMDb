using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using TMDb.Client.Api.V3.Models.TVEpisodes;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class TVEpisodesProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish, "")]
        public async Task TVEpisodesDetailsSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language, string appendToResponse)
        {
            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            Assert.Equal(typeof(TVEpisodesDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task TVEpisodesAccountStatesSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            throw new NotImplementedException("Need guest session id or session id");

            var guestSessionId = "";
            var sessionId = "";

            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesAccountStatesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                GuestSessionId = guestSessionId,
                SessionId = sessionId
            });

            Assert.Equal(typeof(TVEpisodesAccountStatesResponse), response.GetType());
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
        [InlineData((int)TV.GameOfThrones,      1, "2020-01-11", "2020-01-23")]
        public async Task TVEpisodesChangesSmokeTest(int episodeId, int page, string startDate, string endDate)
        {
            throw new NotImplementedException("Need episode id");

            var response = await Client.TVEpisodes.GetAsync(new TVEpisodesChangesRequest
            {
                EpisodeId = episodeId,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            Assert.Equal(typeof(TVEpisodesChangesResponse), response.GetType());
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

            Assert.Equal(typeof(TVEpisodesCreditsResponse), response.GetType());
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

            Assert.Equal(typeof(TVEpisodesExternalIdsResponse), response.GetType());
        }

        public virtual Task<> GetAsync( request) =>
            Client.SendAsync<TVEpisodesExternalIdsResponse>(request);

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

            Assert.True(response.Stills.Count() > 0);
            Assert.Equal(typeof(TVEpisodesImagesResponse), response.GetType());
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

            Assert.Equal(typeof(TVEpisodesTranslationsResponse), response.GetType());
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

            Assert.Equal(typeof(TVEpisodesVideosResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task RateTVEpisodeSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            throw new NotImplementedException("Need guest session id or session id");

            var guestSessionId = "";
            var sessionId = "";

            var response = await Client.TVEpisodes.PostAsync(new RateTVEpisodeRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                GuestSessionId = guestSessionId,
                SessionId = sessionId
            });

            Assert.Equal(typeof(RateTVEpisodeResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror, 1, 1, Language.AmericanEnglish)]
        public async Task DeleteTVEpisodeRatingSmokeTest(int tvId, int seasonNumber, int epsiodeNumber, string language)
        {
            throw new NotImplementedException("Need guest session id or session id");

            var guestSessionId = "";
            var sessionId = "";

            var response = await Client.TVEpisodes.DeleteAsync(new DeleteTVEpisodeRatingRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                EpisodeNumber = epsiodeNumber,
                LanguageAbbreviation = language,
                GuestSessionId = guestSessionId,
                SessionId = sessionId
            });

            Assert.Equal(typeof(DeleteTVEpisodeRatingResponse), response.GetType());
        }
        }
    }
}