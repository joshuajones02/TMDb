using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class CountriesResponse
    {
        public IEnumerable<CountryModel> Countries { get; set; }
    }

    public class CountryModel
    {
        [JsonProperty("iso_3166_1")]
        public string Abbreviation { get; set; }

        [JsonProperty("english_name")]
        public string Country { get; set; }
    }
}