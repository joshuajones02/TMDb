using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Reviews
{
    public class ReviewsResponse : TMDbResponse
    {
        [JsonProperty("media_id")]
        public virtual int MediaId { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("author")]
        public virtual string Author { get; set; }

        [JsonProperty("content")]
        public virtual string Content { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("media_title")]
        public virtual string MediaTitle { get; set; }

        [JsonProperty("media_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public virtual MediaType MediaType { get; set; }

        [JsonProperty("created_at")]
        public virtual DateTime? Created { get; set; }

        [JsonProperty("updated_at")]
        public virtual DateTime? Updated { get; set; }

        [JsonProperty("author_details")]
        public virtual AuthorDetails AuthorDetails { get; set; }

        [JsonProperty("url")]
        public virtual Uri Url { get; set; }
    }
}