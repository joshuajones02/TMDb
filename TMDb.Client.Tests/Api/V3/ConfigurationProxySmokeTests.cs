using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Configuration;
using Xunit;

namespace TMDb.Client.Tests.Api.V3
{
    public class ConfigurationProxySmokeTests : TestsClient
    {
        [Fact]
        public async Task GetConfigurationSmokeTest()
        {
            var response = await Client.Configuration.GetConfigurationAsync();

            Assert.Equal(typeof(ConfigurationResponse), response.GetType());
        }

        [Fact]
        public async Task GetCountriesConfigurationSmokeTest()
        {
            var response = await Client.Configuration.GetCountriesConfigurationAsync();

            Assert.Equal(typeof(CountriesConfigurationResponse), response.GetType());
        }

        [Fact]
        public async Task GetDepartmentJobsSmokeTest()
        {
            var response = await Client.Configuration.GetDepartmentJobsAsync();

            Assert.Equal(typeof(DepartmentJobsConfigurationResponse), response.GetType());
        }

        [Fact]
        public async Task GetLanguagesSmokeTest()
        {
            var response = await Client.Configuration.GetLanguagesAsync();

            Assert.Equal(typeof(LanguagesConfigurationResponse), response.GetType());
        }

        [Fact]
        public async Task GetPrimaryTranslationsSmokeTest()
        {
            var response = await Client.Configuration.GetPrimaryTranslationsAsync();

            Assert.Equal(typeof(PrimaryTranslationsConfigurationResponse), response.GetType());
        }

        [Fact]
        public async Task GetTimezonesSmokeTest()
        {
            var response = await Client.Configuration.GetTimezonesAsync();

            Assert.Equal(typeof(TimezonesConfigurationResponse), response.GetType());
        }
    }
}