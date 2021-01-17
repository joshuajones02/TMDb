using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class ListStatusResponse : TMDbResponse
    {
        [JsonProperty("item_present")]
        public virtual bool ItemPresent { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }
    }
}