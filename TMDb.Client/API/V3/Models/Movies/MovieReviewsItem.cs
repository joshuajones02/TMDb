using Newtonsoft.Json;
using System;

namespace TMDb.Client.Api.V3.Models.Movies
{
    [Obsolete("// TODO: Rename and move to entities (used for both Movies and TV)")]
    public class MovieReviewsItem
    {
        [JsonProperty("author")]
        public virtual string AuthorName { get; set; }

        [JsonProperty("content")]
        public virtual string Content { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("created_at")]
        public virtual DateTime? Created { get; set; }

        [JsonProperty("updated_at")]
        public virtual DateTime? Modified { get; set; }

        [JsonProperty("author_details")]
        public virtual MovieReviewsAuthorDetails AuthorDetails { get; set; }

        [JsonProperty("url")]
        public virtual Uri Url { get; set; }
    }
}