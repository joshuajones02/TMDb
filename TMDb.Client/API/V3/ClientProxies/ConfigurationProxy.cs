using System.Threading.Tasks;
using TMDb.Client.Api.V3.Models.Configuration;

namespace TMDb.Client.Api.V3.ClientProxies
{
    public class ConfigurationProxy : ApiProxy
    {
        public ConfigurationProxy(TMDbClient client) : base(client)
        {
        }

        public virtual Task<ConfigurationResponse> GetConfigurationAsync() =>
            Client.SendAsync<ConfigurationResponse>(new ConfigurationRequest());

        public virtual Task<ConfigurationResponse> GetCountriesConfigurationAsync() =>
            Client.SendAsync<ConfigurationResponse>(new CountriesConfigurationRequest());

        public virtual Task<DepartmentJobsConfigurationResponse> GetDepartmentJobsAsync() =>
            Client.SendAsync<DepartmentJobsConfigurationResponse>(new DepartmentJobsConfigurationRequest());

        public virtual Task<LanguagesConfigurationResponse> GetLanguagesAsync() =>
            Client.SendAsync<LanguagesConfigurationResponse>(new LanguagesConfigurationRequest());

        public virtual Task<PrimaryTranslationsConfigurationResponse> GetPrimaryTranslationsAsync() =>
            Client.SendAsync<PrimaryTranslationsConfigurationResponse>(new PrimaryTranslationsConfigurationRequest());

        public virtual Task<TimezonesConfigurationResponse> GetTimezonesAsync() =>
            Client.SendAsync<TimezonesConfigurationResponse>(new TimezonesConfigurationRequest());
    }
}