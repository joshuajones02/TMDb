using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleChangesItem
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("action")]
        public virtual string Action { get; set; }

        [JsonProperty("time")]
        public virtual string Time { get; set; }

        [JsonProperty("original_value")]
        public virtual OriginalValue OriginalValue { get; set; }
    }
}