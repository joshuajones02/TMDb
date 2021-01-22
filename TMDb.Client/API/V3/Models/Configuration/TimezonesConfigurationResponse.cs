using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    public class TimezonesConfigurationResponse : TMDbResponse
    {
        public virtual IEnumerable<Timezone> Timezones { get; set; }
    }

    public class Timezone
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("zones")]
        public virtual IEnumerable<string> Zones { get; set; }
    }
}