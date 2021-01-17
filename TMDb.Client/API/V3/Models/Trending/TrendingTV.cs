using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Trending
{
    public class TrendingTV : TrendingBaseResult
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime? FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> OriginCountry { get; set; }
    }
}