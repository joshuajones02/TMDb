using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Find
{
    public class FindByIdMovieResult : FindByIdMediaItem
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("video")]
        public virtual bool Video { get; set; }

        [JsonProperty("original_title")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("first_air_date")]
        public override DateTime? ReleaseDate { get; set; }
    }
}