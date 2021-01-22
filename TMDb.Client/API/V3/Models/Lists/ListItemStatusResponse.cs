using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Lists
{
    public class ListItemStatusResponse : TMDbCollectionResponse
    {
        [JsonProperty("item_present")]
        public virtual bool ItemPresent { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }
    }
}