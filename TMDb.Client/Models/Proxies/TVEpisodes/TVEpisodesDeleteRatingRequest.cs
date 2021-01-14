using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesDeleteRatingRequest : TMDbRequest
    {
        [JsonProperty("guest_session_id")]
        public virtual string GuestSessionId { get; set; }

        [JsonProperty("session_id")]
        public virtual string SessionId { get; set; }

        // TODO: Add implementation - this is a header property
        [JsonIgnore]
        [JsonProperty("Content-Type")]
        public virtual string ContentType { get; set; }
    }
}