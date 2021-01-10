using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchTVResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<SearchTVResult> Results { get; set; }
    }

    public partial class SearchTVResult : SearchMediaResult
    {
        [JsonProperty("original_name")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("first_air_date")]
        public DateTime? FirstAirDate { get; set; }

        [JsonProperty("origin_country")]
        public IEnumerable<string> CountryAbbreviations { get; set; }
    }
}