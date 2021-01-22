using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleExternalIdsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int? TMDbId { get; set; }

        [JsonProperty("tvrage_id")]
        public virtual int? TVRageId { get; set; }

        [JsonProperty("tvdb_id")]
        public virtual int TVDbId { get; set; }

        [JsonProperty("facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty("freebase_id")]
        public virtual string FreebaseId { get; set; }

        [JsonProperty("freebase_mid")]
        public virtual string FreebaseMid { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDbId { get; set; }

        [JsonProperty("twitter_id")]
        public string TwitterId { get; set; }
    }
}