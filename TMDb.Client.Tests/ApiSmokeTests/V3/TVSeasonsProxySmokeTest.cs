using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TVSeasons;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class TVSeasonsProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)TV.BlackMirror, 1, Language.AmericanEnglish, "images")]
        [InlineData((int)TV.GameOfThrones, 1, Language.AmericanEnglish, "videos")]
        public async Task TVSeasonsDetailsSmokeTest(int tvId, int seasonNumber, string language, string appendToResponse)
        {
            var response = await Client.TVSeasons.GetAsync(new TVSeasonsDetailsRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            Assert.Equal(typeof(TVSeasonsDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, 1, Language.AmericanEnglish)]
        public async Task TVSeasonsAccountStatesSmokeTest(int tvId, int seasonNumber, string language)
        {
            throw new NotImplementedException("Implement GuestSessionId and SessionId");

            var response = await Client.TVSeasons.GetAsync(new TVSeasonsAccountStatesRequest
            {
                TvId = tvId,
                SeasonNumber = seasonNumber,
                LanguageAbbreviation = language,
                GuestSessionId = "",
                SessionId = ""
            });

            Assert.Equal(typeof(TVSeasonsAccountStatesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.FortyEightHours,    1, Language.AmericanEnglish)]    
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

            Assert.Equal(typeof(TVSeasonsAggregateCreditsResponse), response.GetType());
        }

        [Theory]        
        [InlineData((int)TV.BlackMirror,        1, "2020-12-12", "2020-12-24")]
        [InlineData((int)TV.Dateline,           1, "2020-03-01", "2020-03-14")]
        [InlineData((int)TV.Dexter,             1, "2016-07-17", "2016-07-30")]
        [InlineData((int)TV.FortyEightHours,    1, "2018-09-01", "2018-09-14")]    
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
        [InlineData((int)TV.GameOfThrones,      1, "2019-12-01", "2019-12-14")]
        [InlineData((int)TV.GameOfThrones,      1, "2019-12-15", "2019-12-28")]
        [InlineData((int)TV.GameOfThrones,      1, "2019-12-29", "2019-01-10")]
        [InlineData((int)TV.GameOfThrones,      1, "2020-01-11", "2020-01-23")]
        public async Task TVSeasonsChangesSmokeTest(int tvId, int page, string startDate, string endDate)
        {
            // TODO: Need to convert tvId into season id?
            var seasonId = tvId;
            throw new NotImplementedException("EIther identify season id or convert tv id to season id");

            var response = await Client.TVSeasons.GetAsync(new TVSeasonsChangesRequest
            {
                SeasonId = seasonId,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            Assert.Equal(typeof(TVSeasonsChangesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.FortyEightHours,    1, Language.AmericanEnglish)]    
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

            Assert.Equal(typeof(TVSeasonsCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.FortyEightHours,    1, Language.AmericanEnglish)]    
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

            Assert.Equal(typeof(TVSeasonsExternalIdsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.FortyEightHours,    1, Language.AmericanEnglish)]    
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

            Assert.Equal(typeof(TVSeasonsImagesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.FortyEightHours,    1, Language.AmericanEnglish)]    
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

            Assert.Equal(typeof(TVSeasonsTranslationsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror,        1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dateline,           1, Language.AmericanEnglish)]
        [InlineData((int)TV.Dexter,             1, Language.AmericanEnglish)]
        [InlineData((int)TV.FortyEightHours,    1, Language.AmericanEnglish)]    
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

            Assert.Equal(typeof(TVSeasonsVideosResponse), response.GetType());
        }
    }
}