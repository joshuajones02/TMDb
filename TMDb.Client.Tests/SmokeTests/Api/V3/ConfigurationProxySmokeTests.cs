using System.Linq;
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

            Assert.IsType<ConfigurationResponse>(response);
            Assert.True(response.Images != null);
            Assert.True(response.ChangeKeys.Any());
        }

        [Fact]
        public async Task GetCountriesConfigurationSmokeTest()
        {
            var response = await Client.Configuration.GetCountriesConfigurationAsync();

            Assert.IsType<CountriesConfigurationResponse>(response);
            Assert.True(response.Countries.Any());
        }

        [Fact]
        public async Task GetDepartmentJobsSmokeTest()
        {
            var response = await Client.Configuration.GetDepartmentJobsAsync();

            Assert.IsType<DepartmentJobsConfigurationResponse>(response);
            Assert.True(response.Departments.Any());
        }

        [Fact]
        public async Task GetLanguagesSmokeTest()
        {
            var response = await Client.Configuration.GetLanguagesAsync();

            Assert.IsType<LanguagesConfigurationResponse>(response);
            Assert.True(response.Results.Any());
        }

        [Fact]
        public async Task GetPrimaryTranslationsSmokeTest()
        {
            var response = await Client.Configuration.GetPrimaryTranslationsAsync();

            Assert.IsType<PrimaryTranslationsConfigurationResponse>(response);
            Assert.True(response.LanguageCodeDashRegionCode.Any());
        }

        [Fact]
        public async Task GetTimezonesSmokeTest()
        {
            var response = await Client.Configuration.GetTimezonesAsync();

            Assert.IsType<TimezonesConfigurationResponse>(response);
        }
    }
}