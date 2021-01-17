﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class TimezonesResponse
    {
        public virtual IEnumerable<Timezone> Timezones { get; set; }
    }

    public class Timezone
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryAbbreviation { get; set; }

        [JsonProperty("zones")]
        public virtual string[] Zones { get; set; }
    }
}