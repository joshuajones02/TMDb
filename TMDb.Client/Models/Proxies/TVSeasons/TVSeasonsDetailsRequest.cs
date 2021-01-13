using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsDetailsRequest : TVSeasonsRequest
    {
        [JsonProperty("append_to_response")]
        public virtual string AppendToResponse { get; set; }
    }
}