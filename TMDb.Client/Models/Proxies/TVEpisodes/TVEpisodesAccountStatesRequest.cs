using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesAccountStatesRequest : TVEpisodesRequest
    {
        [JsonProperty("guest_session_id")]
        public virtual string GuestSessionId { get; set; }

        [JsonProperty("session_id")]
        public virtual string SessionId { get; set; }
    }
}