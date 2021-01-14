using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models.Proxies.Collections;

namespace TMDb.Client.Models.Proxies
{
    public class TranslationsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("translations")]
        public virtual IEnumerable<Translation> Translations { get; set; }
    }
}