using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.People
{
    public class PopularPeopleKnownForMovie : KnownForItemBase
    {
        [JsonProperty("adult")]
        public bool? Adult { get; set; }

        [JsonProperty("video")]
        public bool? Video { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("release_date")]
        public DateTime? ReleaseDate { get; set; }
    }
}