using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Reviews
{
    public class AuthorDetails
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("username")]
        public virtual string Username { get; set; }

        [JsonProperty("avatar_path")]
        public virtual string AvatarPath { get; set; }

        [JsonProperty("rating")]
        public virtual float? Rating { get; set; }
    }
}