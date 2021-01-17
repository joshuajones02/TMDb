using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchMoviesResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public IEnumerable<SearchMoviesResult> Results { get; set; }
    }

    public partial class SearchMoviesResult : SearchMediaResult
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }
    }
}