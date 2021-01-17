using Newtonsoft.Json;

namespace TMDb.Client.Entities.Organizations
{
    public class ProductionCompany : Company
    {
        [JsonProperty("origin_country")]
        public virtual string OriginCountry { get; set; }
    }
}