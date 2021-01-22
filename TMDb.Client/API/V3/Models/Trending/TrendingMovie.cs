using Newtonsoft.Json;
using System;

namespace TMDb.Client.Api.V3.Models.Trending
{
    public class TrendingMovie : TrendingBaseResult
    {
        [JsonProperty("adult")]
        public virtual bool? Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool? Video { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("release_date")]
        public virtual DateTime? ReleaseDate { get; set; }
    }
}