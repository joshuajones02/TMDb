using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.Changes
{
    public class ChangeItem
    {
        [JsonProperty("id")]
        public virtual bool Adult { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}