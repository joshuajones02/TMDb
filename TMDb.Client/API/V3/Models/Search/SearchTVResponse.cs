using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchTVResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<SearchTVResult> Results { get; set; }
    }

    public class SearchTVResult : SearchMediaResult
    {
        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("first_air_date")]
        public virtual DateTime? FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> CountryAbbreviations { get; set; }
    }
}