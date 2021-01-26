using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.Configuration
{
    public class LanguagesConfigurationResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Language> Results { get; set; }
    }
}