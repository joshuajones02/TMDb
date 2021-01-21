using TMDb.Client.API.V3.Models.Movies;
using Xunit;

namespace TMDb.Client.Tests
{
    public enum Movies
    {
        BillyMadison =  11017,
        DeathTo2020  = 773655,
        Insidious    =  49018,
        Immortals    =  37958,
        LionKing     =   8587,
        Nosferatu    =    653
    }

    public class MoviesProxyTests : TestsClient
    {
        [Theory]
        [InlineData((int)Movies.BillyMadison)]
        [InlineData((int)Movies.DeathTo2020)]
        [InlineData((int)Movies.Insidious)]
        [InlineData((int)Movies.Immortals)]
        [InlineData((int)Movies.LionKing)]
        [InlineData((int)Movies.Nosferatu)]
        public void GetMovieDetailsTest(int movieId)
        {
            // Arrange
            var request = new MovieDetailsRequest();

            // Act
            var test = Client.Movies.GetAsync(request);

            // Assert
        }
    }
}