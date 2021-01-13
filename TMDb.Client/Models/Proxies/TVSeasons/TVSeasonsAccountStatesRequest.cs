using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsAccountStatesRequest : TVSeasonsRequest
    {
        [JsonProperty("guest_session_id")]
        public virtual string GuestSessionId { get; set; }

        [JsonProperty("session_id")]
        public virtual string SessionId { get; set; }
    }
}