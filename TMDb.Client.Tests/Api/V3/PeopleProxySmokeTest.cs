using System;
using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models;
using TMDb.Client.Api.V3.Models.People;
using TMDb.Client.Tests.TestConstants;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class PeopleProxySmokeTest : TestsClient
    {
        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleDetailsSmokeTest(int personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleDetailsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(PeopleDetailsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,     1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.AdamSandler,    1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.AndersHolm,     1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.BlakeAnderson,  1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.JoeRogan,       1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.PeteDavidson,   1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.RobSchneider,   1, "2020-12-29", "2021-01-10")]
        [InlineData((int)Person.AdamDevine,     1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Person.AdamSandler,    1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Person.AndersHolm,     1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Person.BlakeAnderson,  1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Person.JoeRogan,       1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Person.PeteDavidson,   1, "2021-01-11", "2021-01-23")]
        [InlineData((int)Person.RobSchneider,   1, "2021-01-11", "2021-01-23")]
        public async Task PeopleChangesSmokeTest(int personId, int page, string startDate, string endDate)
        {
            var response = await Client.People.GetAsync(new PeopleChangesRequest
            {
                PersonId = personId,
                Page = page,
                StartDate = DateTime.Parse(startDate),
                EndDate = DateTime.Parse(endDate)
            });

            Assert.Equal(typeof(PeopleChangesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleMovieCreditsSmokeTest(int personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleMovieCreditsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(PeopleMovieCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleTVCreditsSmokeTest(int personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleTVCreditsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(PeopleTVCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleCombinedCreditsSmokeTest(int personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleCombinedCreditsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(PeopleCombinedCreditsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleExternalIdsSmokeTest(int personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleExternalIdsRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(PeopleExternalIdsResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine   )]
        [InlineData((int)Person.AdamSandler  )]
        [InlineData((int)Person.AndersHolm   )]
        [InlineData((int)Person.BlakeAnderson)]
        [InlineData((int)Person.JoeRogan     )]
        [InlineData((int)Person.PeteDavidson )]
        [InlineData((int)Person.RobSchneider )]
        public async Task PeopleImagesSmokeTest(int personId)
        {
            var response = await Client.People.GetAsync(new PeopleImagesRequest
            {
                PersonId = personId
            });

            Assert.Equal(typeof(PeopleImagesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine,    Language.AmericanEnglish)]
        [InlineData((int)Person.AdamSandler,   Language.AmericanEnglish)]
        [InlineData((int)Person.AndersHolm,    Language.AmericanEnglish)]
        [InlineData((int)Person.BlakeAnderson, Language.AmericanEnglish)]
        [InlineData((int)Person.JoeRogan,      Language.AmericanEnglish)]
        [InlineData((int)Person.PeteDavidson,  Language.AmericanEnglish)]
        [InlineData((int)Person.RobSchneider,  Language.AmericanEnglish)]
        public async Task PeopleTaggedImagesSmokeTest(int personId, string language)
        {
            var response = await Client.People.GetAsync(new PeopleTaggedImagesRequest
            {
                PersonId = personId,
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TMDbCollectionResponse), response.GetType());
            Assert.Equal(typeof(PeopleTaggedImagesResponse), response.GetType());
        }

        [Theory]
        [InlineData((int)Person.AdamDevine   )]
        [InlineData((int)Person.AdamSandler  )]
        [InlineData((int)Person.AndersHolm   )]
        [InlineData((int)Person.BlakeAnderson)]
        [InlineData((int)Person.JoeRogan     )]
        [InlineData((int)Person.PeteDavidson )]
        [InlineData((int)Person.RobSchneider )]
        public async Task PeopleTranslationsSmokeTest(int personId)
        {
            var response = await Client.People.GetAsync(new PeopleTranslationsRequest
            {
                PersonId = personId
            });

            Assert.Equal(typeof(PeopleTranslationsResponse), response.GetType());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        public async Task LatestPeopleSmokeTest(string language)
        {
            var response = await Client.People.GetAsync(new LatestPeopleRequest
            {
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TMDbCollectionResponse), response.GetType());
            Assert.Equal(typeof(LatestPeopleResponse), response.GetType());
        }

        [Theory]
        [InlineData(Language.AmericanEnglish)]
        public async Task SmokeTest(string language)
        {
            var response = await Client.People.GetAsync(new PopularPeopleRequest
            {
                LanguageAbbreviation = language
            });

            Assert.Equal(typeof(TMDbCollectionResponse), response.GetType());
            Assert.Equal(typeof(PopularPeopleResponse), response.GetType());
        }
    }
}