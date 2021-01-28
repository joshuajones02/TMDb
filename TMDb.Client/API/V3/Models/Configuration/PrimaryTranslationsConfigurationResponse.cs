using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    public class PrimaryTranslationsConfigurationResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<string> LanguageCodeDashRegionCode { get; set; }
    }
}