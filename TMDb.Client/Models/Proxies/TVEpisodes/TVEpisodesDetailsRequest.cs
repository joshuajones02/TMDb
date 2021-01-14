using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesDetailsRequest : TVEpisodesRequest
    {
        [JsonProperty("append_to_response")]
        public virtual string AppendToResponse { get; set; }
    }
}