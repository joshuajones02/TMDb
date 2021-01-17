using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class PrimaryTranslationsResponse
    {
        public virtual IEnumerable<string> LanguageCodeDashRegionCode { get; set; }
    }
}