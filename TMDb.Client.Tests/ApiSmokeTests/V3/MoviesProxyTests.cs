using System.Threading.Tasks;
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

    public static class Language
    {
        public const string AmericanEnglish = "en-US";
        public const string BritishEnglish = "en-GB";
        public const string CanadianFrench = "fr-CA";
        public const string Chinese = "zh-CN";
        public const string FinlandSwedish = "sv-FI";
        public const string German = "de-DE";
        public const string Italian = "it-IT";
        public const string MexicanSpanish = "es-MX";
    }

    public class MoviesProxyTests : TestsClient
    {
        [Theory]
        [InlineData((int)Movies.BillyMadison, Language.AmericanEnglish, null                        )]
        [InlineData((int)Movies.DeathTo2020,  Language.Chinese,         "videos"                    )]
        [InlineData((int)Movies.Insidious,    Language.German,          "videos"                    )]
        [InlineData((int)Movies.Immortals,    Language.Italian,         "videos,images"             )]
        [InlineData((int)Movies.LionKing,     Language.Chinese,         "videos,images,translations")]
        [InlineData((int)Movies.Nosferatu,    Language.CanadianFrench,  null                        )]
        public async Task GetMovieDetailsTest(int movieId, string language, string appendToResponse)
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
    }
}