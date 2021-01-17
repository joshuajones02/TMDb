using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Reviews
{
    public class ReviewsResponse : TMDbResponse
    {
        [JsonProperty("media_id")]
        public int MediaId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("iso_639_1")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("media_title")]
        public string MediaTitle { get; set; }

        [JsonProperty("media_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaType MediaType { get; set; }

        [JsonProperty("created_at")]
        public DateTime? Created { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? Updated { get; set; }

        [JsonProperty("author_details")]
        public AuthorDetails AuthorDetails { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }
}