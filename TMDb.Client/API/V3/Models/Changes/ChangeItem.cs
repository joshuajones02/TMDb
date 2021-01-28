using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Changes
{
    public class ChangeItem
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}