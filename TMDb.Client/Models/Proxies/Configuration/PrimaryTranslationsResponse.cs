using System.Collections.Generic;

namespace TMDb.Client.Models.Configuration
{
    public class PrimaryTranslationsResponse
    {
        public IEnumerable<string> LanguageCodeDashRegionCode { get; set; }
    }
}