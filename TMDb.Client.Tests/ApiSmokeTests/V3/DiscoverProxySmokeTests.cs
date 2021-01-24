using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Discover;
using TMDb.Client.Enums;
using Xunit;

namespace TMDb.Client.Tests.ApiSmokeTests.V3
{
    public class DiscoverProxySmokeTests : TestsClient
    {
        [Theory]
        [InlineData(
/*                        string LanguageAbbreviation                   */ Language.AmericanEnglish,
/*                        string RegionCountryCode                      */ CountryCode.UnitedStatesOfAmerica,
/*           DiscoverMovieSortBy SortBy                                 */ DiscoverMovieSortBy.PopularityAscending,
/*                        string CertificationCountry                   */ CountryCode.UnitedStatesOfAmerica,
/*                        string Certification                          */ null, // TODO: get certification,
/*                        string CertificationLessThanOrEqualTo         */ null, // TODO: get certificationLessThanOrEqualTo,
/*                        string CertificationGreaterThanOrEqualTo      */ null, // TODO: get certificationGreaterThanOrEqualTo,
/*                         bool? IncludeAdult                           */ null,
/*                         bool? IncludeVideo                           */ true,
/*                           int Page                                   */ 1,
/*                        short? PrimaryReleaseYear                     */ 2020,
/*                     DateTime? PrimaryReleaseDateGreaterThanOrEqualTo */ null,
/*                     DateTime? PrimaryReleaseDateLessThanOrEqualTo    */ null,
/*                     DateTime? ReleaseDateGreaterThanOrEqualTo        */ null,
/*                     DateTime? ReleaseDateLessThanOrEqualTo           */ null,
/* IEnumerable<MovieReleaseType> WithReleaseTypes                       */ null, // TODO: ReleaseTypeEnums
/* IEnumerable<MovieReleaseType> WithEitherReleaseTypes                 */ null, // TODO: ReleaseTypeEnums
/*                        short? Year                                   */ 2020,
/*                          int? VoteCountGreaterThanOrEqualTo          */ 1,
/*                          int? VoteCountLessThanOrEqualTo             */ 9999,
/*                          int? VoteAverageGreaterThanOrEqualTo        */ 5,
/*                          int? VoteAverageLessThanOrEqualTo           */ 10,
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
/*                        string WithOriginalLanguageAbbreviation       */ Language.AmericanEnglish,
/*              IEnumerable<int> WithWatchProviderIds                   */ null, // new int[] { 10, 20, 30 } // TODO: Get withWatchProviderIds,
/*              IEnumerable<int> WithEitherWatchProviderIds             */ null, // new int[] { 10, 20, 30 } // TODO: Get withEitherWatchProviderIds,
/*                        string WithWatchProviderRegionCountryCode     */ CountryCode.UnitedStatesOfAmerica)]
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
            short? primaryReleaseYear,
            DateTime? primaryReleaseDateGreaterThanOrEqualTo,
            DateTime? primaryReleaseDateLessThanOrEqualTo,
            DateTime? releaseDateGreaterThanOrEqualTo,
            DateTime? releaseDateLessThanOrEqualTo,
            IEnumerable<MovieReleaseType> withReleaseTypes,
            IEnumerable<MovieReleaseType> withEitherReleaseTypes,
            short? year,
            int? voteCountGreaterThanOrEqualTo,
            int? voteCountLessThanOrEqualTo,
            int? voteAverageGreaterThanOrEqualTo,
            int? voteAverageLessThanOrEqualTo,
            IEnumerable<int> withCastIds,
            IEnumerable<int> withCrewIds,
            IEnumerable<int> withPeopleIds,
            IEnumerable<int> withCompanyIds,
            IEnumerable<int> withGenreIds,
            IEnumerable<int> withEitherGenreIds,
            IEnumerable<int> withoutGenreIds,
            IEnumerable<int> withoutEitherGenreIds,
            IEnumerable<int> withKeywordIds,
            IEnumerable<int> withEitherKeywordIds,
            IEnumerable<int> withoutKeywordIds,
            IEnumerable<int> withoutEitherKeywordIds,
            int? withRuntimeGreaterThanOrEqualTo,
            int? withRuntimeLessThanOrEqualTo,
            string withOriginalLanguageAbbreviation,
            IEnumerable<int> withWatchProviderIds,
            IEnumerable<int> withEitherWatchProviderIds,
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
                PrimaryReleaseYear = primaryReleaseYear,
                PrimaryReleaseDateGreaterThanOrEqualTo = primaryReleaseDateGreaterThanOrEqualTo,
                PrimaryReleaseDateLessThanOrEqualTo = primaryReleaseDateLessThanOrEqualTo,
                ReleaseDateGreaterThanOrEqualTo = releaseDateGreaterThanOrEqualTo,
                ReleaseDateLessThanOrEqualTo = releaseDateLessThanOrEqualTo,
                WithReleaseTypes = withReleaseTypes,
                WithEitherReleaseTypes = withEitherReleaseTypes,
                Year = year,
                VoteCountGreaterThanOrEqualTo = voteCountGreaterThanOrEqualTo,
                VoteCountLessThanOrEqualTo = voteCountLessThanOrEqualTo,
                VoteAverageGreaterThanOrEqualTo = voteAverageGreaterThanOrEqualTo,
                VoteAverageLessThanOrEqualTo = voteAverageLessThanOrEqualTo,
                WithCastIds = withCastIds,
                WithCrewIds = withCrewIds,
                WithPeopleIds = withPeopleIds,
                WithCompanyIds = withCompanyIds,
                WithGenreIds = withGenreIds,
                WithEitherGenreIds = withEitherGenreIds,
                WithoutGenreIds = withoutGenreIds,
                WithoutEitherGenreIds = withoutEitherGenreIds,
                WithKeywordIds = withKeywordIds,
                WithEitherKeywordIds = withEitherKeywordIds,
                WithoutKeywordIds = withoutKeywordIds,
                WithoutEitherKeywordIds = withoutEitherKeywordIds,
                WithRuntimeGreaterThanOrEqualTo = withRuntimeGreaterThanOrEqualTo,
                WithRuntimeLessThanOrEqualTo = withRuntimeLessThanOrEqualTo,
                WithOriginalLanguageAbbreviation = withOriginalLanguageAbbreviation,
                WithWatchProviderIds = withWatchProviderIds,
                WithEitherWatchProviderIds = withEitherWatchProviderIds,
                WithWatchProviderRegionCountryCode = withWatchProviderRegionCountryCode,
            });

            Assert.Equal(typeof(DiscoverMovieResponse), response.GetType());
        }

        [Theory]
        [InlineData()]
        public async Task DiscoverTVSmokeTest()
        {
            throw new NotImplementedException("Finish implementing...");
            var response = await Client.Discover.GetAsync(new DiscoverTVRequest());

            Assert.Equal(typeof(DiscoverTVResponse), response.GetType());
        }
    }
}