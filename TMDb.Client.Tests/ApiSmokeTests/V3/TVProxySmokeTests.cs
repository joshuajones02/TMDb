using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.TV;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class TVProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData((int)TV.BlackMirror, Language.AmericanEnglish)]
        [InlineData((int)TV.GameOfThrones, Language.BritishEnglish)]
        [InlineData((int)TV.StrangerThings, Language.CanadianFrench)]
        public async Task AlternativeTVTitlesSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new AlternativeTVTitlesRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(AlternativeTVTitlesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones)]
        public async Task DeleteRatingSmokeTest(int tvId)
        {
            throw new NotImplementedException("Implement GuestSessionId and SessionId, remove ContentType - always Json");

            var response = await Client.TV.DeleteAsync(new DeleteTVRatingRequest
            {
                TVId = tvId,
                //ContentType = ContentType.JsonText,
                GuestSessionId = "",
                SessionId = ""
            });

            Assert.Equal(typeof(DeleteTVRatingResponse), response.GetType());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        public async Task LatestTVSmokeTest(string language)
        {
            var response = await Client.TV.GetAsync(new LatestTVRequest
            {
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(LatestTVResponse), response.GetType());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish)]
        public async Task PopularTVSmokeTest(int page, string language)
        {
            var response = await Client.TV.GetAsync(new PopularTVRequest
            {
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(PopularTVResponse), response.GetType());
        }

        // TODO: Needs guest session id or session id
        [Theory]
        [InlineData((int)TV.GameOfThrones, 10)]
        [InlineData((int)TV.LetterKenny, 9.5)]
        [InlineData((int)TV.MindHunter, 8.5)]
        public async Task RateTVSmokeTest(int tvId, float rating)
        {
            throw new NotImplementedException("Implement GuestSessionId and SessionId, remove ContentType - always Json");

            var response = await Client.TV.PostAsync(new RateTVRequest
            {
                TVId = tvId,
                //ContentType = ContentType.JsonText,
                GuestSessionId = "",
                SessionId = "",
                Rating = rating
            });

            Assert.Equal(typeof(RateTVResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, 1, Language.AmericanEnglish)]
        [InlineData((int)TV.GameOfThrones, 2, Language.AmericanEnglish)]
        [InlineData((int)TV.GameOfThrones, 3, Language.AmericanEnglish)]
        public async Task SimilarTVSmokeTest(int tvId, int page, string language)
        {
            var response = await Client.TV.GetAsync(new SimilarTVRequest
            {
                TVId = tvId,
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(SimilarTVResponse), response.GetType());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish)]
        [InlineData(10, Language.CanadianFrench)]
        [InlineData(11, Language.Chinese)]
        [InlineData(12, Language.FinlandSwedish)]
        [InlineData(13, Language.MexicanSpanish)]
        [InlineData(14, Language.Italian)]
        public async Task TopRatedTVSmokeTest(int page, string language)
        {
            var response = await Client.TV.GetAsync(new TopRatedTVRequest
            {
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TopRatedTVResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVAccountStatesSmokeTest(int tvId, string language)
        {
            throw new NotImplementedException("Implement GuestSessionId and SessionId");

            var response = await Client.TV.GetAsync(new TVAccountStatesRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language,
                GuestSessionId = "",
                SessionId = ""
            });

            Assert.Equal(typeof(TVAccountStatesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVAggregateCreditsSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVAggregateCreditsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVAggregateCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish)]
        [InlineData(10, Language.CanadianFrench)]
        [InlineData(11, Language.Chinese)]
        [InlineData(12, Language.FinlandSwedish)]
        [InlineData(13, Language.MexicanSpanish)]
        [InlineData(14, Language.Italian)]
        public async Task TVAiringTodaySmokeTest(int page, string language)
        {
            var response = await Client.TV.GetAsync(new TVAiringTodayRequest
            {
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVAiringTodayResponse), response.GetType());
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
        public async Task TVChangesSmokeTest(int tvId, int page, string startDate, string endDate)
        {
            var response = await Client.TV.GetAsync(new TVChangesRequest
            {
                TVId = tvId,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            Assert.Equal(typeof(TVChangesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVContentRatingsSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVContentRatingsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVContentRatingsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVCreditsSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVCreditsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish, "videos")]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish, "images")]
        public async Task TVDetailsSmokeTest(int tvId, string language, string appendToResponse)
        {
            var response = await Client.TV.GetAsync(new TVDetailsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language,
                AppendToResponse = appendToResponse
            });

            Assert.Equal(typeof(TVDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVEpisodeGroupsSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVEpisodeGroupsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVEpisodeGroupsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVExternalIdsSmokeRequest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVExternalIdsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVExternalIdsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVImagesSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVImagesRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVImagesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones)]
        public async Task TVKeywordsSmokeTest(int tvId)
        {
            var response = await Client.TV.GetAsync(new TVKeywordsRequest
            {
                TVId = tvId
            });

            Assert.Equal(typeof(TVKeywordsResponse), response.GetType());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish)]
        [InlineData(2, Language.AmericanEnglish)]
        [InlineData(3, Language.AmericanEnglish)]
        [InlineData(4, Language.AmericanEnglish)]
        [InlineData(5, Language.AmericanEnglish)]
        [InlineData(6, Language.AmericanEnglish)]
        [InlineData(7, Language.AmericanEnglish)]
        [InlineData(9, Language.AmericanEnglish)]
        public async Task TVOnTheAirSmokeTest(int page, string language)
        {
            var response = await Client.TV.GetAsync(new TVOnTheAirRequest
            {
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVOnTheAirResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones,  1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,      2, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,      3, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,      4, Language.AmericanEnglish)]
        public async Task TVRecommendationsSmokeTest(int tvId, int page, string language)
        {
            var response = await Client.TV.GetAsync(new TVRecommendationsRequest
            {
                TVId = tvId,
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVRecommendationsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones,  1, Language.AmericanEnglish)]
        [InlineData((int)TV.TheOffice,      2, Language.AmericanEnglish)]
        [InlineData((int)TV.Shameless,      3, Language.AmericanEnglish)]
        [InlineData((int)TV.SouthPark,      4, Language.AmericanEnglish)]
        public async Task TVReviewsSmokeTest(int tvId, int page, string language)
        {
            var response = await Client.TV.GetAsync(new TVReviewsRequest
            {
                TVId = tvId,
                Page = page,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVReviewsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror)]
        [InlineData((int)TV.Dateline)]
        [InlineData((int)TV.Dexter)]
        [InlineData((int)TV.FortyEightHours)]
        [InlineData((int)TV.LetterKenny)]
        [InlineData((int)TV.MindHunter)]
        [InlineData((int)TV.ModernFamily)]
        [InlineData((int)TV.Ozark)]
        [InlineData((int)TV.ParksAndRecreation)]
        [InlineData((int)TV.RickAndMorty)]
        [InlineData((int)TV.Shameless)]
        [InlineData((int)TV.SouthPark)]
        [InlineData((int)TV.StrangerThings)]
        [InlineData((int)TV.TheOffice)]
        [InlineData((int)TV.TheTwilightZone)]
        [InlineData((int)TV.TheTwilightZone2)]
        [InlineData((int)TV.TwentyTwenty)]
        [InlineData((int)TV.GameOfThrones)]
        public async Task TVScreenedTheatricallySmokeTest(int tvId)
        {
            var response = await Client.TV.GetAsync(new TVScreenedTheatricallyRequest
            {
                TVId = tvId
            });

            Assert.Equal(typeof(TVScreenedTheatricallyResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVTranslationsSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVTranslationsRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVTranslationsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.GameOfThrones, Language.AmericanEnglish)]
        public async Task TVVideosSmokeTest(int tvId, string language)
        {
            var response = await Client.TV.GetAsync(new TVVideosRequest
            {
                TVId = tvId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TVVideosResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)TV.BlackMirror)]
        [InlineData((int)TV.Dateline)]
        [InlineData((int)TV.Dexter)]
        [InlineData((int)TV.FortyEightHours)]
        [InlineData((int)TV.LetterKenny)]
        [InlineData((int)TV.MindHunter)]
        [InlineData((int)TV.ModernFamily)]
        [InlineData((int)TV.Ozark)]
        [InlineData((int)TV.ParksAndRecreation)]
        [InlineData((int)TV.RickAndMorty)]
        [InlineData((int)TV.Shameless)]
        [InlineData((int)TV.SouthPark)]
        [InlineData((int)TV.StrangerThings)]
        [InlineData((int)TV.TheOffice)]
        [InlineData((int)TV.TheTwilightZone)]
        [InlineData((int)TV.TheTwilightZone2)]
        [InlineData((int)TV.TwentyTwenty)]
        [InlineData((int)TV.GameOfThrones)]
        public async Task TVWatchProvidersSmokeTest(int tvId)
        {
            var response = await Client.TV.GetAsync(new TVWatchProvidersRequest
            {
                TVId = tvId
            });

            Assert.Equal(typeof(TVWatchProvidersResponse), response.GetType());
        }
    }
}