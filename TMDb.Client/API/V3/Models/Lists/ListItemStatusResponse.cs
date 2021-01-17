using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class ListStatusResponse : TMDbResponse
    {
        [JsonProperty("item_present")]
        public bool ItemPresent { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}