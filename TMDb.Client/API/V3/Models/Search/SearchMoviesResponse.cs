using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchMoviesResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<SearchMoviesResult> Results { get; set; }
    }

    public class SearchMoviesResult : SearchMediaResult
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("release_date")]
        public virtual DateTime? ReleaseDate { get; set; }
    }
}