using Newtonsoft.Json;
using System;

namespace TMDb.Client.Api.V3.Models.Movies
{
    [Obsolete("// TODO: Rename and move to entities")]
    public class MovieReviewsAuthorDetails
    {
        [JsonProperty("rating")]
        public virtual int? Rating { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("username")]
        public virtual string Username { get; set; }

        [JsonProperty("avatar_path")]
        public virtual string AvatarPath { get; set; }
    }
}