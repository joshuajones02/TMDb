using System;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models;
using TMDb.Client.Api.V3.Models.Search;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
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

            Assert.IsType<MultiSearchResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData("horror",     1, Language.AmericanEnglish)]
        [InlineData("collezione", 1, Language.Italian)]
        public async Task SearchCollectionsSmokeTest(string query, int page, string language)
        {
            var response = await Client.Search.GetAsync(new SearchCollectionsRequest
            {
                Page = page,
                Query = query,
                LanguageAbbreviation = language
            });

            Assert.IsType<SearchCollectionsResponse>(response);
            Assert.True(response.Collections.Any());
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

            Assert.IsType<SearchCompaniesResponse>(response);
            Assert.True(response.Companies.Any());
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

            Assert.IsType<SearchKeywordsResponse>(response);
            Assert.True(response.Keywords.Any());
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

            Assert.IsType<SearchMoviesResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData("adam", 1, Language.AmericanEnglish, null, null)]
        [InlineData("pete", 1, Language.AmericanEnglish, null, false)]
        public async Task SearchPeopleSmokeTest(string query, int page, string language, string region, bool? includeAdult)
        {
            var response = await Client.Search.GetAsync(new SearchPeopleRequest
            {
                Page = page,
                Query = query,
                IncludeAdult = includeAdult,
                LanguageAbbreviation = language,
                Region = region
            });

            Assert.IsType<SearchPeopleResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData("dateline",   1, Language.AmericanEnglish, 2010, false)]
        [InlineData("true crime", 1, Language.AmericanEnglish, 2010, false)]
        public async Task SearchTVSmokeTest(string query, int page, string language, int? firstAirDateYear, bool? includeAdult)
        {
            var response = await Client.Search.GetAsync(new SearchTVRequest
            {
                Page = page,
                Query = query,
                LanguageAbbreviation = language,
                FirstAirDateYear = Convert.ToInt16(firstAirDateYear),
                IncludeAdult = includeAdult, 
            });

            Assert.IsType<SearchTVResponse>(response);
        }
    }
}