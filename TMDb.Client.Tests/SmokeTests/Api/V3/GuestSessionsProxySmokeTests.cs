using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.GuestSessionRated;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class GuestSessionsProxySmokeTests : TestsClient
    {
        // TODO: GuestSessionId
        [Theory]
        [InlineData(Language.AmericanEnglish, GuestSessionRatingSortyBy.CreatedAscending,  "")]
        [InlineData(Language.CanadianFrench,  GuestSessionRatingSortyBy.CreatedDescending, "")]
        [InlineData(Language.Chinese,         GuestSessionRatingSortyBy.CreatedDescending, "")]
        [InlineData(Language.German,          GuestSessionRatingSortyBy.CreatedAscending,  "")]
        [InlineData(Language.Italian,         GuestSessionRatingSortyBy.CreatedAscending,  "")]
        public async Task GuestSessionRatedMoviesSmokeTest(string language, GuestSessionRatingSortyBy sortBy, string guestSessionId)
        {
            //var response = await Client.GuestSessions.GetAsync(new GuestSessionRatedMoviesRequest
            //{
            //    LanguageAbbreviation = language,
            //    SortBy = sortBy,
            //    GuestSessionId = guestSessionId
            //});

            //Assert.IsType<GuestSessionRatedMoviesResponse>(response);
        }

        // TODO: GuestSessionId
        [Theory]
        [InlineData(Language.AmericanEnglish, GuestSessionRatingSortyBy.CreatedAscending,  "")]
        [InlineData(Language.CanadianFrench,  GuestSessionRatingSortyBy.CreatedDescending, "")]
        [InlineData(Language.Chinese,         GuestSessionRatingSortyBy.CreatedDescending, "")]
        [InlineData(Language.German,          GuestSessionRatingSortyBy.CreatedAscending,  "")]
        [InlineData(Language.Italian,         GuestSessionRatingSortyBy.CreatedAscending,  "")]
        public async Task GuestSessionRatedTVSmokeTest(string language, GuestSessionRatingSortyBy sortBy, string guestSessionId)
        {
            //var response = await Client.GuestSessions.GetAsync(new GuestSessionRatedTVRequest
            //{
            //    LanguageAbbreviation = language,
            //    SortBy = sortBy,
            //    GuestSessionId = guestSessionId
            //});

            //Assert.IsType<GuestSessionRatedMoviesResponse>(response);
        }

        // TODO: GuestSessionId
        [Theory]
        [InlineData(Language.AmericanEnglish, GuestSessionRatingSortyBy.CreatedAscending,  "")]
        [InlineData(Language.CanadianFrench,  GuestSessionRatingSortyBy.CreatedDescending, "")]
        [InlineData(Language.Chinese,         GuestSessionRatingSortyBy.CreatedDescending, "")]
        [InlineData(Language.German,          GuestSessionRatingSortyBy.CreatedAscending,  "")]
        [InlineData(Language.Italian,         GuestSessionRatingSortyBy.CreatedAscending,  "")]
        public async Task GuestSessionRatedTVEpisodesSmokeTest(string language, GuestSessionRatingSortyBy sortBy, string guestSessionId)
        {
            //var response = await Client.GuestSessions.GetAsync(new GuestSessionRatedTVEpisodesRequest
            //{
            //    LanguageAbbreviation = language,
            //    SortBy = sortBy,
            //    GuestSessionId = guestSessionId
            //});

            //Assert.IsType<GuestSessionRatedTVEpisodesResponse>(response);
        }
    }
}