using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Movies
{
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
