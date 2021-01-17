using Newtonsoft.Json;

namespace TMDb.Client.Entities.Places
{
    public class ProductionCountry
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }
    }
}