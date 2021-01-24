using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Movies;
using Xunit;

namespace TMDb.Client.Tests
{
    public class MoviesProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData((int)Movies.Insidious, CountryCode.Italy)]
        [InlineData((int)Movies.Immortals, CountryCode.Japan)]
        public async Task AlternativeMovieTitlesSmokeTest(int movieId, string countryCode)
        {
            var request = new AlternativeMovieTitlesRequest
            {
                MovieId = movieId,
                CountryCode = countryCode
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(AlternativeMovieTitlesResponse), response.GetType());
        }

        // TODO: Requires GuestSessionId or SessionId
        //[Theory]
        //[InlineData((int)Movies.Insidious, CountryCode.Italy)]
        //[InlineData((int)Movies.Immortals, CountryCode.Japan)]
        //public async Task DeleteMovieRatingSmokeTest(int movieId, string countryCode)
        //{
        //    var request = new DeleteMovieRatingRequest 
        //    { 
        //        MovieId = movieId,
        //        CountryCode = countryCode
        //    };

        //    var response = await Client.Movies.GetAsync(request);

        //    Assert.Equal(typeof(DeleteMovieRatingResponse), response.GetType());
        //}


        [Theory]
        [InlineData(Language.AmericanEnglish)]
        [InlineData(Language.BritishEnglish)]
        [InlineData(Language.CanadianFrench)]
        [InlineData(Language.Chinese)]
        [InlineData(Language.FinlandSwedish)]
        [InlineData(Language.German)]
        [InlineData(Language.Italian)]
        [InlineData(Language.MexicanSpanish)]
        public async Task LatestMovieSmokeTest(string language)
        {
            var request = new LatestMoviesRequest
            {
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(LatestMoviesResponse), response.GetType());
        }

        // TODO: Need "SessionId" in order to hit this endpoint.. setup later
        //[Theory]
        //public async Task MovieAccountStatesSmokeTest(string movieId)
        //{
        //    var request = new MovieAccountStatesRequest
        //    {
        //        MovieId = movieId,
        //        SessionId = ,
        //        GuestSessionId =
        //    };

        //    var response = await Client.Movies.GetAsync(request);

        //    Assert.Equal(typeof(LatestMoviesResponse), response.GetType());
        //}

        [Theory]
        [InlineData((int)Movies.BillyMadison,        1, "2020-12-12", "2020-12-24")]
        [InlineData((int)Movies.AvengersEndGame,     1, "2020-03-01", "2020-03-14")]
        [InlineData((int)Movies.Immortals,           1, "2016-07-17", "2016-07-30")]
        [InlineData((int)Movies.AvengersEndGame,     1, "2018-09-01", "2018-09-14")]
        [InlineData((int)Movies.AvengersEndGame,     1, "2020-02-20", "2017-03-01")]
        [InlineData((int)Movies.AvengersInfinityWar, 1, "2019-11-10", "2019-11-23")]
        [InlineData((int)Movies.TheAvengers,         1, "2020-12-12", "2020-12-24")]
        [InlineData((int)Movies.Immortals,           1, "2020-03-01", "2020-03-14")]
        [InlineData((int)Movies.HarryPotter,         1, "2016-07-17", "2016-07-30")]
        [InlineData((int)Movies.LionKing,            1, "2018-09-01", "2018-09-14")]
        [InlineData((int)Movies.TheAvengers,         1, "2020-02-20", "2017-03-01")]
        [InlineData((int)Movies.BillyMadison,        1, "2019-11-10", "2019-11-23")]
        [InlineData((int)Movies.TheAvengers,         1, "2019-11-10", "2019-11-23")]
        [InlineData((int)Movies.WonderWoman1984,     1, "2020-12-01", "2020-12-14")]
        [InlineData((int)Movies.WonderWoman1984,     1, "2020-12-15", "2020-12-28")]
        [InlineData((int)Movies.WonderWoman1984,     1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Movies.WonderWoman1984,     1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Movies.Jumanji,             1, "2019-12-01", "2019-12-14")]
        [InlineData((int)Movies.Jumanji,             1, "2019-12-15", "2019-12-28")]
        [InlineData((int)Movies.Jumanji,             1, "2019-12-29", "2019-01-10")]
        [InlineData((int)Movies.Jumanji,             1, "2020-01-11", "2020-01-23")]
        public async Task MovieChangesSmokeTest(int movieId, int page, string startDate, string endDate)
        {
            var request = new MovieChangesRequest
            {
                MovieId = movieId,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            };
            try
            {
            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieChangesResponse), response.GetType());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.TraceInformation(ex.ToString());
            }
        }

        [Theory]
        [InlineData((int)Movies.Insidious, Language.AmericanEnglish)]
        [InlineData((int)Movies.Immortals, Language.Italian)]
        public async Task MovieCreditsSmokeTest(int movieId, string language)
        {
            var request = new MovieCreditsRequest
            {
                MovieId = movieId,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.BillyMadison, Language.AmericanEnglish, null                        )]
        [InlineData((int)Movies.DeathTo2020,  Language.Chinese,         "videos"                    )]
        [InlineData((int)Movies.Insidious,    Language.German,          "videos"                    )]
        [InlineData((int)Movies.Immortals,    Language.Italian,         "videos,images"             )]
        [InlineData((int)Movies.LionKing,     Language.Chinese,         "videos,images,translations")]
        [InlineData((int)Movies.Nosferatu,    Language.CanadianFrench,  null                        )]
        public async Task MovieDetailsSmokeTest(int movieId, string language, string appendToResponse)
        {
            var request = new MovieDetailsRequest
            {
                MovieId = movieId,
                AppendToResponse = appendToResponse,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious)]
        [InlineData((int)Movies.Immortals)]
        public async Task MovieExternalIdsSmokeTest(int movieId)
        {
            var request = new MovieExternalIdsRequest
            {
                MovieId = movieId
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieExternalIdsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious, Language.Italian, "en")]
        [InlineData((int)Movies.Immortals, Language.AmericanEnglish, "fr,sv,zh,es")]
        public async Task MovieImagesSmokeTest(int movieId, string language, string imageLanguage)
        {
            var request = new MovieImagesRequest
            {
                MovieId = movieId,
                LanguageAbbreviation = language,
                ImageLanguage = imageLanguage
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieImagesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.BillyMadison)]
        [InlineData((int)Movies.DeathTo2020)]
        [InlineData((int)Movies.Insidious)]
        public async Task MovieKeywordsSmokeTest(int movieId)
        {
            var request = new MovieKeywordsRequest
            {
                MovieId = movieId
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieKeywordsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious, 1, Language.AmericanEnglish)]
        [InlineData((int)Movies.LionKing, 2, Language.MexicanSpanish)]
        public async Task MoveListsSmokeTest(int movieId, int page, string language)
        {
            var request = new MovieListsRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieListsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious, 2, Language.AmericanEnglish)]
        [InlineData((int)Movies.BillyMadison, 3, Language.MexicanSpanish)]
        public async Task MovieRecommendationsSmokeTest(int movieId, int page, string language)
        {
            var request = new MovieRecommendationsRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieRecommendationsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious)]
        public async Task MovieReleaseDatesSmokeTest(int movieId)
        {
            var request = new MovieReleaseDatesRequest
            {
                MovieId = movieId
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieReleaseDatesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious, 2, Language.AmericanEnglish)]
        [InlineData((int)Movies.Nosferatu, 1, Language.CanadianFrench)]
        public async Task MovieReviewsSmokeTest(int movieId, int page, string language)
        {
            var request = new MovieReviewsRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieReviewsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious, Language.AmericanEnglish)]
        public async Task MovieTranslationsSmokeTest(int movieId, string language)
        {
            var request = new MovieTranslationsRequest
            {
                MovieId = movieId
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieTranslationsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Insidious, Language.AmericanEnglish)]
        public async Task MovieVideosSmokeTest(int movieId, string language)
        {
            var request = new MovieVideosRequest
            {
                MovieId = movieId,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieVideosResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Movies.Immortals)]
        [InlineData((int)Movies.Nosferatu)]
        public async Task MovieWatchProvidersSmokeTest(int movieId)
        {
            var request = new MovieWatchProvidersRequest
            {
                MovieId = movieId
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(MovieWatchProvidersResponse), response.GetType());
        }

        [Theory]
        [InlineData(3, Language.AmericanEnglish, "us")]
        public async Task NowPlayingSmokeTest(int page, string language, string countryCode)
        {
            var request = new NowPlayingMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(NowPlayingMoviesResponse), response.GetType());
        }

        [Theory]
        [InlineData(3, Language.AmericanEnglish, "us")]
        public async Task PopularMoviesSmokeTest(int page, string language, string countryCode)
        {
            var request = new PopularMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(PopularMoviesResponse), response.GetType());
        }


        // TODO: Session Id or Session Id is required
        //[Theory]
        //[InlineData((int)Movies.Insidious, 10)]
        //[InlineData((int)Movies.Immortals, 10)]
        //public async Task RateMoviesSmokeTest(int movieId, int rating)
        //{
        //    var guestSessionId = string.Empty;
        //    var sessionId = string.Empty;

        //    var request = new RateMovieRequest
        //    {
        //        MovieId = movieId,
        //        // TODO: Broken
        //        // ** //ContentType = ContentType.Json, 
        //        //GuestSessionId = guestSessionId,
        //        //SessionId = sessionId,
        //        Rating = rating
        //    };

        //    var response = await Client.Movies.PostAsync(request);

        //    Assert.Equal(typeof(RateMovieResponse), response.GetType());
        //}

        [Theory]
        [InlineData((int)Movies.Insidious, 1, Language.AmericanEnglish)]
        public async Task SimilarMoviesSmokeTest(int movieId, int page, string language)
        {
            var request = new SimilarMoviesRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(SimilarMoviesResponse), response.GetType());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish, "us")]
        public async Task TopRatedMoviesSmokeTest(int page, string language, string countryCode)
        {
            var request = new TopRatedMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(TopRatedMoviesResponse), response.GetType());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish, "us")]
        public async Task UpcomingMoviesSmokeTest(int page, string language, string countryCode)
        {
            var request = new UpcomingMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            };

            var response = await Client.Movies.GetAsync(request);

            Assert.Equal(typeof(UpcomingMoviesResponse), response.GetType());
        }
    }
}