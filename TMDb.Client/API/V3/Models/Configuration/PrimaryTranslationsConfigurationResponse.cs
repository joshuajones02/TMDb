using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class PrimaryTranslationsConfigurationResponse : TMDbResponse
    {
        public virtual IEnumerable<string> LanguageCodeDashRegionCode { get; set; }
    }
}