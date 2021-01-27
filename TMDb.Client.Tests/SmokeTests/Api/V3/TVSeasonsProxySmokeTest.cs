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
        public async Task<TVSeasonsDetailsResponse> TVSeasonsDetailsSmokeTest(int tvId, int seasonNumber, string language, string appendToResponse)
        {
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            Assert.IsType<TVSeasonsDetailsResponse>(response);

            return response;
        }

        // TODO: Need GuestSessionId and SessionId
        [Theory]
        [InlineData((int)TV.GameOfThrones, 1, Language.AmericanEnglish)]
        public async Task TVSeasonsAccountStatesSmokeTest(int tvId, int seasonNumber, string language)
        {
            //var guestSessionId = "";
            //var sessionId = "";

            //var response = await Client.TVSeasons.GetAsync(new TVSeasonsAccountStatesRequest
            //{
            //    TvId = tvId,
            //    SeasonNumber = seasonNumber,
            //    LanguageAbbreviation = language,
            //    GuestSessionId = guestSessionId,
            //    SessionId = sessionId
            //});

            //Assert.IsType<TVSeasonsAccountStatesResponse>(response);
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
        public async Task TVSeasonsAggregateCreditsSmokeTest(int tvId, int seasonNumber, string language)
        {
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsAggregateCreditsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVSeasonsAggregateCreditsResponse>(response);
            Assert.True(response.Cast.Any());
            Assert.True(response.Crew.Any());
        }

        [Theory]        
        [InlineData((int)TV.BlackMirror,        1, "2020-12-12", "2020-12-24")]
        [InlineData((int)TV.Dateline,           1, "2020-03-01", "2020-03-14")]
        [InlineData((int)TV.GameOfThrones,      1, "2019-12-15", "2019-12-28")]
        [InlineData((int)TV.GameOfThrones,      1, "2019-12-29", "2019-01-10")]
        [InlineData((int)TV.GameOfThrones,      1, "2020-01-11", "2020-01-23")]
        [InlineData((int)TV.LetterKenny,        1, "2020-02-20", "2017-03-01")]
        [InlineData((int)TV.MindHunter,         1, "2019-11-10", "2019-11-23")]
        [InlineData((int)TV.ModernFamily,       1, "2020-12-12", "2020-12-24")]
        [InlineData((int)TV.Ozark,              1, "2020-03-01", "2020-03-14")]
        [InlineData((int)TV.ParksAndRecreation, 1, "2016-07-17", "2016-07-30")]
        [InlineData((int)TV.RickAndMorty,       1, "2018-09-01", "2018-09-14")]
        [InlineData((int)TV.Shameless,          1, "2020-02-20", "2017-03-01")]
        [InlineData((int)TV.SouthPark,          1, "2019-11-10", "2019-11-23")]
        [InlineData((int)TV.StrangerThings,     1, "2019-11-10", "2019-11-23")]
        [InlineData((int)TV.TheOffice,          1, "2020-12-01", "2020-12-14")]
        [InlineData((int)TV.TheTwilightZone,    1, "2020-12-15", "2020-12-28")]
        [InlineData((int)TV.TheTwilightZone2,   1, "2020-12-29", "2021-01-10")]
        [InlineData((int)TV.TwentyTwenty,       1, "2021-01-11", "2021-01-23")]
        public async Task TVSeasonsChangesSmokeTest(int tvId, int page, string startDate, string endDate)
        {
            var seasonDetails = await TVSeasonsDetailsSmokeTest(tvId, 1, Language.AmericanEnglish, null);

            var response = await Client.TVSeasons.GetAsync(new TVSeasonsChangesRequest
            {
                SeasonId = seasonDetails.Id,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

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
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsCreditsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVSeasonsCreditsResponse>(response);
            Assert.True(response.Cast.Any());
            Assert.True(response.Crew.Any());
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
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsExternalIdsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

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
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsImagesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVSeasonsImagesResponse>(response);
            Assert.True(response.Posters.Any());
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
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsTranslationsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVSeasonsTranslationsResponse>(response);
            Assert.True(response.Translations.Any());
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
        public async Task TVSeasonsVideosSmokeTest(int tvId, int seasonNumber, string language)
        {
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsVideosRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language
            });

            Assert.IsType<TVSeasonsVideosResponse>(response);
            Assert.True(response.Videos.Any());
        }
    }
}