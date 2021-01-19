using Newtonsoft.Json;

namespace TMDb.Client.API.V3.Models.People
{
    public class PersonTranslationData
    {
        [JsonProperty("biography")]
        public virtual string Biography { get; set; }
    }
}