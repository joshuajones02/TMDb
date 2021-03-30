using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class TranslationDataItem
    {
        [JsonProperty("title")]
        public virtual string Title { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("homepage")]
        public virtual string Homepage { get; set; }
    }
}