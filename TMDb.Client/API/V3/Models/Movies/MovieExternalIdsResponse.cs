using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Movies
{
    public class MovieExternalIdsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("imdb_id")]
        public virtual string IMDbId { get; set; }

        [JsonProperty("facebook_id")]
        public virtual string FacebookId { get; set; }

        [JsonProperty("instagram_id")]
        public virtual string InstagramId { get; set; }

        [JsonProperty("twitter_id")]
        public virtual string TwitterId { get; set; }
    }
}