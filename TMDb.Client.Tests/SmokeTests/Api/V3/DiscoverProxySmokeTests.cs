using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Discover;
using TMDb.Client.Enums;
using Xunit;

namespace TMDb.Client.Tests.SmokeTests.Api.V3
{
    public class DiscoverProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData(
/*                        string LanguageAbbreviation                   */ Language.AmericanEnglish,
/*                        string RegionCountryCode                      */ null, // CountryCode.UnitedStatesOfAmerica,
/*           DiscoverMovieSortBy SortBy                                 */ null, // DiscoverMovieSortBy.PopularityAscending,
/*                        string CertificationCountry                   */ null, // sCountryCode.UnitedStatesOfAmerica,
/*                        string Certification                          */ null, // TODO: get certification,
/*                        string CertificationLessThanOrEqualTo         */ null, // TODO: get certificationLessThanOrEqualTo,
/*                        string CertificationGreaterThanOrEqualTo      */ null, // TODO: get certificationGreaterThanOrEqualTo,
/*                         bool? IncludeAdult                           */ null,
/*                         bool? IncludeVideo                           */ true,
/*                           int Page                                   */ 1,
/*                        short? PrimaryReleaseYear                     */ null,
/*                     DateTime? PrimaryReleaseDateGreaterThanOrEqualTo */ "01/01/2020",
/*                     DateTime? PrimaryReleaseDateLessThanOrEqualTo    */ null,
/*                     DateTime? ReleaseDateGreaterThanOrEqualTo        */ null,
/*                     DateTime? ReleaseDateLessThanOrEqualTo           */ null,
/* IEnumerable<MovieReleaseType> WithReleaseTypes                       */ null, // TODO: ReleaseTypeEnums
/* IEnumerable<MovieReleaseType> WithEitherReleaseTypes                 */ null, // TODO: ReleaseTypeEnums
/*                        short? Year                                   */ null,
/*                          int? VoteCountGreaterThanOrEqualTo          */ null,
/*                          int? VoteCountLessThanOrEqualTo             */ null,
/*                          int? VoteAverageGreaterThanOrEqualTo        */ null,
/*                          int? VoteAverageLessThanOrEqualTo           */ null,
/*              IEnumerable<int> WithCastIds                            */ null, // new int[] { 10, 20, 30 } // TODO: Get withCastIds,
/*              IEnumerable<int> WithCrewIds                            */ null, // new int[] { 10, 20, 30 } // TODO: Get withCrewIds,
/*              IEnumerable<int> WithPeopleIds                          */ null, // new int[] { 10, 20, 30 } // TODO: Get withPeopleIds,
/*              IEnumerable<int> WithCompanyIds                         */ null, // new int[] { 10, 20, 30 } // TODO: Get withCompanyIds,
/*              IEnumerable<int> WithGenreIds                           */ null, // new int[] { 10, 20, 30 } // TODO: Get withGenreIds,
/*              IEnumerable<int> WithEitherGenreIds                     */ null, // new int[] { 10, 20, 30 } // TODO: Get withEitherGenreIds,
/*              IEnumerable<int> WithoutGenreIds                        */ null, // new int[] { 10, 20, 30 } // TODO: Get withoutGenreIds,
/*              IEnumerable<int> WithoutEitherGenreIds                  */ null, // new int[] { 10, 20, 30 } // TODO: Get withoutEitherGenreIds,
/*              IEnumerable<int> WithKeywordIds                         */ null, // new int[] { 10, 20, 30 } // TODO: Get withKeywordIds,
/*              IEnumerable<int> WithEitherKeywordIds                   */ null, // new int[] { 10, 20, 30 } // TODO: Get withEitherKeywordIds,
/*              IEnumerable<int> WithoutKeywordIds                      */ null, // new int[] { 10, 20, 30 } // TODO: Get withoutKeywordIds,
/*              IEnumerable<int> WithoutEitherKeywordIds                */ null, // new int[] { 10, 20, 30 } // TODO: Get WithoutEitherKeywordIds,
/*                          int? WithRuntimeGreaterThanOrEqualTo        */ 60,
/*                          int? WithRuntimeLessThanOrEqualTo           */ null,
/*                        string WithOriginalLanguageAbbreviation       */ null,
/*              IEnumerable<int> WithWatchProviderIds                   */ null, // new int[] { 10, 20, 30 } // TODO: Get withWatchProviderIds,
/*              IEnumerable<int> WithEitherWatchProviderIds             */ null, // new int[] { 10, 20, 30 } // TODO: Get withEitherWatchProviderIds,
/*                        string WithWatchProviderRegionCountryCode     */ null)]
        public async Task DiscoverMovieSmokeTest(
            string language,
            string region,
            DiscoverMovieSortBy sortBy,
            string certificationCountry,
            string certification,
            string certificationLessThanOrEqualTo,
            string certificationGreaterThanOrEqualTo,
            bool? includeAdult,
            bool? includeVideo,
            int page,
            int? primaryReleaseYear,
            string primaryReleaseDateGreaterThanOrEqualTo,
            string primaryReleaseDateLessThanOrEqualTo,
            string releaseDateGreaterThanOrEqualTo,
            string releaseDateLessThanOrEqualTo,
            IEnumerable<MovieReleaseType> withReleaseTypes,
            Delimeter withReleaseTypesDelimeter,
            int? year,
            int? voteCountGreaterThanOrEqualTo,
            int? voteCountLessThanOrEqualTo,
            int? voteAverageGreaterThanOrEqualTo,
            int? voteAverageLessThanOrEqualTo,
            IEnumerable<int> withCastIds,
            IEnumerable<int> withCrewIds,
            IEnumerable<int> withPeopleIds,
            IEnumerable<int> withCompanyIds,
            IEnumerable<int> withGenreIds,
            Delimeter withGenreIdsDelimeter,
            IEnumerable<int> withoutGenreIds,
            Delimeter withoutGenreIdsDelimeter,
            IEnumerable<int> withKeywordIds,
            Delimeter withKeywordIdsDelimeter,
            IEnumerable<int> withoutKeywordIds,
            Delimeter withoutKeywordIdsDelimeter,
            int? withRuntimeGreaterThanOrEqualTo,
            int? withRuntimeLessThanOrEqualTo,
            string withOriginalLanguageAbbreviation,
            IEnumerable<int> withWatchProviderIds,
            Delimeter withWatchProviderIdsDelimeter,
            string withWatchProviderRegionCountryCode)
        {
            var response = await Client.Discover.GetAsync(new DiscoverMovieRequest
            {
                LanguageAbbreviation = language,
                RegionCountryCode = region,
                SortBy = sortBy,
                CertificationCountry = certificationCountry,
                Certification = certification,
                CertificationLessThanOrEqualTo = certificationLessThanOrEqualTo,
                CertificationGreaterThanOrEqualTo = certificationGreaterThanOrEqualTo,
                IncludeAdult = includeAdult,
                IncludeVideo = includeVideo,
                Page = page,
                PrimaryReleaseYear = primaryReleaseYear.HasValue ? Convert.ToInt16(primaryReleaseYear) : null,
                PrimaryReleaseDateGreaterThanOrEqualTo = !string.IsNullOrEmpty(primaryReleaseDateGreaterThanOrEqualTo) ? DateTime.Parse(primaryReleaseDateGreaterThanOrEqualTo) : null,
                PrimaryReleaseDateLessThanOrEqualTo = !string.IsNullOrEmpty(primaryReleaseDateLessThanOrEqualTo) ? DateTime.Parse(primaryReleaseDateLessThanOrEqualTo) : null,
                ReleaseDateGreaterThanOrEqualTo = !string.IsNullOrEmpty(releaseDateGreaterThanOrEqualTo) ? DateTime.Parse(releaseDateGreaterThanOrEqualTo) : null,
                ReleaseDateLessThanOrEqualTo = !string.IsNullOrEmpty(releaseDateLessThanOrEqualTo) ? DateTime.Parse(releaseDateLessThanOrEqualTo) : null,
                WithReleaseTypes = withReleaseTypes,
                WithReleaseTypesDelimeter = withReleaseTypesDelimeter,
                Year = year.HasValue ? Convert.ToInt16(year) : null,
                VoteCountGreaterThanOrEqualTo = voteCountGreaterThanOrEqualTo,
                VoteCountLessThanOrEqualTo = voteCountLessThanOrEqualTo,
                VoteAverageGreaterThanOrEqualTo = voteAverageGreaterThanOrEqualTo,
                VoteAverageLessThanOrEqualTo = voteAverageLessThanOrEqualTo,
                WithCastIds = withCastIds,
                WithCrewIds = withCrewIds,
                WithPeopleIds = withPeopleIds,
                WithCompanyIds = withCompanyIds,
                WithGenreIds = withGenreIds,
                WithGenreIdsDelimeter = withGenreIdsDelimeter,
                WithoutGenreIds = withoutGenreIds,
                WithoutGenreIdsDelimeter = withoutGenreIdsDelimeter,
                WithKeywordIds = withKeywordIds,
                WithKeywordIdsDelimeter = withKeywordIdsDelimeter,
                WithoutKeywordIds = withoutKeywordIds,
                WithoutKeywordIdsDelimeter = withoutKeywordIdsDelimeter,
                WithRuntimeGreaterThanOrEqualTo = withRuntimeGreaterThanOrEqualTo,
                WithRuntimeLessThanOrEqualTo = withRuntimeLessThanOrEqualTo,
                WithOriginalLanguageAbbreviation = withOriginalLanguageAbbreviation,
                WithWatchProviderIds = withWatchProviderIds,
                WithWatchProviderIdsDelimeter = withWatchProviderIdsDelimeter,
                WithWatchProviderRegionCountryCode = withWatchProviderRegionCountryCode,
            });

            Assert.IsType<DiscoverMovieResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Theory]
        [InlineData(2020)]
        public async Task DiscoverTVSmokeTest(int? firstAirDateYear)
        {
            var response = await Client.Discover.GetAsync(new DiscoverTVRequest 
            { 
                FirstAirDateYear = Convert.ToInt16(firstAirDateYear)
            });

            Assert.IsType<DiscoverTVResponse>(response);
            Assert.True(response.Results.Any());
        }
    }
}