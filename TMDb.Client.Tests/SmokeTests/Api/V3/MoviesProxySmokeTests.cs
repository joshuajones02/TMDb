using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Authentication;
using TMDb.Client.Api.V3.Models.Movies;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class MoviesProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData((int)Movie.Insidious, CountryCode.UnitedStatesOfAmerica)]
        [InlineData((int)Movie.Immortals, CountryCode.Japan)]
        public async Task AlternativeMovieTitlesSmokeTest(int movieId, string countryCode)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new AlternativeMovieTitlesRequest
            {
                MovieId = movieId,
                CountryCode = countryCode
            });

            // Assert
            Assert.IsType<AlternativeMovieTitlesResponse>(response);
            Assert.True(response.Titles.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious)]
        [InlineData((int)Movie.Immortals)]
        public async Task DeleteMovieRatingSmokeTest(int movieId)
        {
            // Arrange
            var createGuestSessionResponse = await Client.Authentication.GetAsync(new CreateGuestSessionRequest());
            var guestSessionId = createGuestSessionResponse.GuestSessionId;
            await Client.Movies.PostAsync(new RateMovieRequest
            {
                MovieId = movieId,
                GuestSessionId = createGuestSessionResponse.GuestSessionId,
                Rating = 10
            });

            // Act
            var response = await Client.Movies.DeleteAsync(new DeleteMovieRatingRequest
            {
                MovieId = movieId,
                GuestSessionId = guestSessionId,
            });

            // Assert
            Assert.IsType<DeleteMovieRatingResponse>(response);
        }

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
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new LatestMoviesRequest
            {
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<LatestMoviesResponse>(response);
        }

        [Theory]
        [InlineData((int)Movie.Insidious)]
        public async Task MovieAccountStatesSmokeTest(int movieId)
        {
            // Arrange
            // Act
            var accountData = await GetAccountDataAsync();
            var sessionId = accountData.SessionId;

            var response = await Client.Movies.GetAsync(new MovieAccountStatesRequest
            {
                MovieId = movieId,
                SessionId = sessionId,
            });

            // Assert
            Assert.IsType<MovieAccountStatesResponse>(response);
            Assert.True(response.Favorite != null);
            Assert.True(response.Watchlist != null);
            Assert.True(response.Rated != null);
        }

        [Theory]
        [InlineData((int)Movie.AvengersEndGame, 1, "2018-09-01", "2018-09-14")]
        [InlineData((int)Movie.AvengersEndGame, 1, "2020-02-20", "2020-03-01")]
        [InlineData((int)Movie.AvengersEndGame, 1, "2020-03-01", "2020-03-14")]
        [InlineData((int)Movie.AvengersInfinityWar, 1, "2019-11-10", "2019-11-23")]
        [InlineData((int)Movie.HarryPotter, 1, "2016-07-17", "2016-07-30")]
        [InlineData((int)Movie.Immortals, 1, "2020-03-01", "2020-03-14")]
        [InlineData((int)Movie.Jumanji, 1, "2019-12-01", "2019-12-14")]
        [InlineData((int)Movie.Jumanji, 1, "2019-12-15", "2019-12-28")]
        [InlineData((int)Movie.Jumanji, 1, "2020-01-11", "2020-01-23")]
        [InlineData((int)Movie.TheAvengers, 1, "2019-11-10", "2019-11-23")]
        [InlineData((int)Movie.TheAvengers, 1, "2020-02-20", "2020-03-01")]
        [InlineData((int)Movie.TheAvengers, 1, "2020-12-12", "2020-12-24")]
        [InlineData((int)Movie.WonderWoman1984, 1, "2020-12-01", "2020-12-14")]
        [InlineData((int)Movie.WonderWoman1984, 1, "2020-12-15", "2020-12-28")]
        [InlineData((int)Movie.WonderWoman1984, 1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Movie.WonderWoman1984, 1, "2021-01-11", "2021-01-23")]
        public async Task MovieChangesSmokeTest(int movieId, int page, string startDate, string endDate)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieChangesRequest
            {
                MovieId = movieId,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            // Assert
            Assert.IsType<MovieChangesResponse>(response);
            Assert.True(response.Changes.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious, Language.AmericanEnglish)]
        [InlineData((int)Movie.Immortals, Language.Italian)]
        public async Task MovieCreditsSmokeTest(int movieId, string language)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieCreditsRequest
            {
                MovieId = movieId,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<MovieCreditsResponse>(response);
            Assert.True(response.Cast.Any());
            Assert.True(response.Crew.Any());
        }

        [Theory]
        [InlineData((int)Movie.BillyMadison, Language.AmericanEnglish, null)]
        [InlineData((int)Movie.DeathTo2020, Language.Chinese, "videos")]
        [InlineData((int)Movie.Insidious, Language.German, "videos")]
        [InlineData((int)Movie.Immortals, Language.Italian, "videos,images")]
        [InlineData((int)Movie.LionKing, Language.Chinese, "videos,images,translations")]
        [InlineData((int)Movie.Nosferatu, Language.CanadianFrench, null)]
        public async Task MovieDetailsSmokeTest(int movieId, string language, string appendToResponse)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieDetailsRequest
            {
                MovieId = movieId,
                AppendToResponse = appendToResponse,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<MovieDetailsResponse>(response);
        }

        [Theory]
        [InlineData((int)Movie.Insidious)]
        [InlineData((int)Movie.Immortals)]
        public async Task MovieExternalIdsSmokeTest(int movieId)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieExternalIdsRequest
            {
                MovieId = movieId
            });

            // Assert
            Assert.IsType<MovieExternalIdsResponse>(response);
        }

        [Theory]
        [InlineData((int)Movie.Insidious, Language.Italian, "en")]
        [InlineData((int)Movie.Immortals, Language.AmericanEnglish, "fr,sv,zh,es")]
        public async Task MovieImagesSmokeTest(int movieId, string language, string imageLanguage)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieImagesRequest
            {
                MovieId = movieId,
                LanguageAbbreviation = language,
                ImageLanguage = imageLanguage
            });

            // Assert
            Assert.IsType<MovieImagesResponse>(response);
            Assert.True(response.Backdrops.Any() || response.Posters.Any());
        }

        [Theory]
        [InlineData((int)Movie.BillyMadison)]
        [InlineData((int)Movie.DeathTo2020)]
        [InlineData((int)Movie.Insidious)]
        public async Task MovieKeywordsSmokeTest(int movieId)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieKeywordsRequest
            {
                MovieId = movieId
            });

            // Assert
            Assert.IsType<MovieKeywordsResponse>(response);
            Assert.True(response.Keywords.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious, 1, Language.AmericanEnglish)]
        [InlineData((int)Movie.LionKing, 2, Language.MexicanSpanish)]
        public async Task MoveListsSmokeTest(int movieId, int page, string language)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieListsRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<MovieListsResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious, 2, Language.AmericanEnglish)]
        [InlineData((int)Movie.BillyMadison, 1, Language.MexicanSpanish)]
        public async Task MovieRecommendationsSmokeTest(int movieId, int page, string language)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieRecommendationsRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<MovieRecommendationsResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious)]
        public async Task MovieReleaseDatesSmokeTest(int movieId)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieReleaseDatesRequest
            {
                MovieId = movieId
            });

            // Assert
            Assert.IsType<MovieReleaseDatesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.AvengersEndGame, 1, Language.AmericanEnglish)]
        [InlineData((int)Movie.Insidious, 1, Language.AmericanEnglish)]
        [InlineData((int)Movie.TheAvengers, 1, Language.AmericanEnglish)]
        public async Task MovieReviewsSmokeTest(int movieId, int page, string language)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieReviewsRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<MovieReviewsResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious)]
        public async Task MovieTranslationsSmokeTest(int movieId)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieTranslationsRequest
            {
                MovieId = movieId
            });

            // Assert
            Assert.IsType<MovieTranslationsResponse>(response);
        }

        [Theory]
        [InlineData((int)Movie.Insidious, Language.AmericanEnglish)]
        public async Task MovieVideosSmokeTest(int movieId, string language)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieVideosRequest
            {
                MovieId = movieId,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<MovieVideosResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Deadpool)]
        [InlineData((int)Movie.Immortals)]
        [InlineData((int)Movie.Insidious)]
        [InlineData((int)Movie.Mulan)]
        public async Task MovieWatchProvidersSmokeTest(int movieId)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new MovieWatchProvidersRequest
            {
                MovieId = movieId
            });

            // Assert
            Assert.IsType<MovieWatchProvidersResponse>(response);
            Assert.True(response?.Results?.US != null);
            Assert.True(response?.Results?.US?.FlatRate.Any() == true
                     || response?.Results?.US?.Rent.Any() == true
                     || response?.Results?.US?.Buy.Any() == true);
        }

        [Theory]
        [InlineData(3, Language.AmericanEnglish, "us")]
        public async Task NowPlayingSmokeTest(int page, string language, string countryCode)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new NowPlayingMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            });

            // Assert
            Assert.IsType<NowPlayingMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData(3, Language.AmericanEnglish, "us")]
        public async Task PopularMoviesSmokeTest(int page, string language, string countryCode)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new PopularMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            });

            // Assert
            Assert.IsType<PopularMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData((int)Movie.Insidious, 10)]
        [InlineData((int)Movie.Immortals, 10)]
        [InlineData((int)Movie.Jumanji, 7.5)]
        public async Task RateMoviesSmokeTest(int movieId, float rating)
        {
            // Arrange
            var createGuestSessionResponse = await Client.Authentication.GetAsync(new CreateGuestSessionRequest());
            var guestSessionId = createGuestSessionResponse.GuestSessionId;

            // Act
            var response = await Client.Movies.PostAsync(new RateMovieRequest
            {
                MovieId = movieId,
                GuestSessionId = guestSessionId,
                Rating = rating
            });

            // Assert
            Assert.IsType<RateMovieResponse>(response);

            // Cleanup
            await Client.Movies.DeleteAsync(new DeleteMovieRatingRequest
            {
                MovieId = movieId,
                GuestSessionId = guestSessionId,
            });
        }

        [Theory]
        [InlineData((int)Movie.Insidious, 1, Language.AmericanEnglish)]
        public async Task SimilarMoviesSmokeTest(int movieId, int page, string language)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new SimilarMoviesRequest
            {
                MovieId = movieId,
                Page = page,
                LanguageAbbreviation = language
            });

            // Assert
            Assert.IsType<SimilarMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish, "us")]
        public async Task TopRatedMoviesSmokeTest(int page, string language, string countryCode)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new TopRatedMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            });

            // Assert
            Assert.IsType<TopRatedMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData(1, Language.AmericanEnglish, "us")]
        public async Task UpcomingMoviesSmokeTest(int page, string language, string countryCode)
        {
            // Arrange
            // Act
            var response = await Client.Movies.GetAsync(new UpcomingMoviesRequest
            {
                Page = page,
                LanguageAbbreviation = language,
                CountryCode = countryCode
            });

            // Assert
            Assert.IsType<UpcomingMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }
    }
}