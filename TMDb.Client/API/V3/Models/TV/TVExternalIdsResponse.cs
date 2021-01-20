using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVExternalIdsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("tvdb_id")]
        public virtual int? TVDbId { get; set; }

        [JsonProperty("tvrage_id")]
        public virtual int? TVRageId { get; set; }

        [JsonProperty("imdb_id")]
        public virtual string IMDbId { get; set; }

        [JsonProperty("freebase_mid")]
        public virtual string FreebaseMid { get; set; }

        [JsonProperty("freebase_id")]
        public virtual string FreebaseId { get; set; }

        [JsonProperty("facebook_id")]
        public virtual string FacebookId { get; set; }

        [JsonProperty("instagram_id")]
        public virtual string InstagramId { get; set; }

        [JsonProperty("twitter_id")]
        public virtual string TwitterId { get; set; }
    }
}