using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVChangesResultItem
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("time")]
        public virtual string Time { get; set; }

        [JsonProperty("action")]
        public virtual string Action { get; set; }

        [JsonProperty("value")]
        public virtual JToken Value { get; set; }

        [JsonProperty("original_value")]
        public virtual JToken OriginalValue { get; set; }
    }
}