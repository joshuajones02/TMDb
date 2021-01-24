using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    public class CountriesConfigurationResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<CountryModel> Countries { get; set; }
    }

    public class CountryModel
    {
        [JsonProperty("iso_3166_1")]
        public virtual string Abbreviation { get; set; }

        [JsonProperty("english_name")]
        public virtual string Country { get; set; }
    }
}