using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.People
{
    public class PopularPeopleKnownForTV : KnownForItemBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime? FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public IEnumerable<string> OriginCountry { get; set; }
    }
}