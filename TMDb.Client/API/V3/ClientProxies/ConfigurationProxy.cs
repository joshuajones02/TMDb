using System;
using System.Threading.Tasks;
using TMDb.Client.API.V3.Models.Configuration;

namespace TMDb.Client.API.V3.ClientProxies
{
    public class ConfigurationProxy : ApiProxy
    {
        public ConfigurationProxy(TMDbClient client) : base(client) =>
            Path = "/configuration";

        protected string Path { get; }

        private Uri SerializeUri(string path) =>
            Serialize(path, new ConfigurationRequest());

        public virtual Task<ImageResponse> GetImageConfiguration() =>
            Client.GetAsync<ImageResponse>(SerializeUri(Path));

        public virtual Task<CountriesResponse> GetCountries() =>
            Client.GetAsync<CountriesResponse>(SerializeUri("/configuration/countries"));

        public virtual Task<DepartmentJobsResponse> GetDepartmentJobs() =>
            Client.GetAsync<DepartmentJobsResponse>(SerializeUri("/configuration/jobs"));

        public virtual Task<LanguagesResponse> GetLanguages() =>
            Client.GetAsync<LanguagesResponse>(SerializeUri("/configuration/languages"));

        public virtual Task<PrimaryTranslationsResponse> GetPrimaryTranslations() =>
            Client.GetAsync<PrimaryTranslationsResponse>(SerializeUri("/configuration/primary_translations"));

        public virtual Task<TimezonesResponse> GetTimezones() =>
            Client.GetAsync<TimezonesResponse>(SerializeUri("/configuration/timezones"));
    }
}