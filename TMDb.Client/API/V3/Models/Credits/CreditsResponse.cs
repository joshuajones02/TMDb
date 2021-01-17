using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;
using TMDb.Client.Entities.People;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Credits
{
    public class CreditsResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("credit_type")]
        public virtual string CreditType { get; set; }

        [JsonProperty("department")]
        public virtual string Department { get; set; }

        [JsonProperty("job")]
        public virtual string Job { get; set; }

        [JsonProperty("media_type")]
        public virtual MediaType MediaType { get; set; }

        [JsonProperty("media")]
        public virtual Media Media { get; set; }

        [JsonProperty("person")]
        public virtual Person Person { get; set; }
    }

    public class Media
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("character")]
        public virtual string Character { get; set; }

        [JsonProperty("episodes")]
        public virtual IEnumerable<Episode> Episodes { get; set; }

        [JsonProperty("seasons")]
        public virtual IEnumerable<Season> Seasons { get; set; }
    }
}