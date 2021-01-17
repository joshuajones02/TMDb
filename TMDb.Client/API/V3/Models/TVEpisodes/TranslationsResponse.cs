using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.Collections;

namespace TMDb.Client.API.V3.Models
{
    public class TranslationsResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("translations")]
        public virtual IEnumerable<Translation> Translations { get; set; }
    }
}