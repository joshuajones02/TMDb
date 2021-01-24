using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models;
using TMDb.Client.Api.V3.Models.Search;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class SearchProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData("game of thrones", 1, Language.AmericanEnglish, CountryCode.UnitedStatesOfAmerica, false)]
        [InlineData("true crime",      1, Language.AmericanEnglish, CountryCode.UnitedStatesOfAmerica, false)]
        public async Task MultiSearchSmokeTest(string query, int page, string language, string region, bool includeAdult)
        {
            var response = await Client.Search.GetAsync(new MultiSearchRequest
            {
                Page = page,
                Query = query,
                IncludeAdult = includeAdult,
                LanguageAbbreviation = language,
                Region = region
            });

            Assert.Equal(typeof(TMDbCollectionResponse), response.GetType());
            Assert.Equal(typeof(MultiSearchResponse), response.GetType());
        }

        [Theory]
        [InlineData("game of thrones", 1, Language.AmericanEnglish)]
        [InlineData("true crime",      1, Language.AmericanEnglish)]
        public async Task SearchCollectionsSmokeTest(string query, int page, string language)
        {
            var response = await Client.Search.GetAsync(new SearchCollectionsRequest
            {
                Page = page,
                Query = query,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(SearchCollectionsResponse), response.GetType());
        }

        [Theory]
        [InlineData("hbo", 1)]
        [InlineData("abc", 1)]
        public async Task SearchCompaniesSmokeTest(string query, int page)
        {
            var response = await Client.Search.GetAsync(new SearchCompaniesRequest
            {
                Page = page,
                Query = query
            });

            Assert.Equal(typeof(SearchCompaniesResponse), response.GetType());
        }

        [Theory]
        [InlineData("thriller",   1)]
        [InlineData("true crime", 1)]
        public async Task SearchKeywordsSmokeTest(string query, int page)
        {
            var response = await Client.Search.GetAsync(new SearchKeywordsRequest
            {
                Page = page,
                Query = query
            });

            Assert.Equal(typeof(SearchKeywordsResponse), response.GetType());
        }

        [Theory]
        [InlineData("insidious", 1, Language.AmericanEnglish, false)]
        [InlineData("replica",   1, Language.AmericanEnglish, false)]
        public async Task SearchMoviesSmokeTest(string query, int page, string language, bool includeAdult)
        {
            var response = await Client.Search.GetAsync(new SearchMoviesRequest
            {
                Page = page,
                Query = query,
                IncludeAdult = includeAdult,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(SearchMoviesResponse), response.GetType());
        }

        [Theory]
        [InlineData("game of thrones", 1, Language.AmericanEnglish, CountryCode.UnitedStatesOfAmerica, false)]
        [InlineData("true crime",      1, Language.AmericanEnglish, CountryCode.UnitedStatesOfAmerica, false)]
        public async Task SearchPeopleSmokeTest(string query, int page, string language, string region, bool includeAdult)
        {
            var response = await Client.Search.GetAsync(new SearchPeopleRequest
            {
                Page = page,
                Query = query,
                IncludeAdult = includeAdult,
                LanguageAbbreviation = language,
                Region = region
            });

            Assert.Equal(typeof(SearchPeopleResponse), response.GetType());
        }

        [Theory]
        [InlineData("dateline",   1, Language.AmericanEnglish, CountryCode.UnitedStatesOfAmerica, false)]
        [InlineData("true crime", 1, Language.AmericanEnglish, CountryCode.UnitedStatesOfAmerica, false)]
        public async Task SearchTVSmokeTest(string query, int page, string language, string region, bool includeAdult)
        {
            var response = await Client.Search.GetAsync(new SearchTVRequest
            {
                Page = page,
                Query = query,
                IncludeAdult = includeAdult,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(SearchTVResponse), response.GetType());
        }
    }
}