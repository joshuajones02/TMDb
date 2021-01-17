﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class CountriesResponse
    {
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