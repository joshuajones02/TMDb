using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Configuration
{
    public class TimezonesResponse
    {
        public IEnumerable<Timezone> Timezones { get; set; }
    }

    public class Timezone
    {
        [JsonProperty("iso_3166_1")]
        public string CountryAbbreviation { get; set; }

        [JsonProperty("zones")]
        public string[] Zones { get; set; }
    }
}