using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Configuration
{
    public class PrimaryTranslationsResponse
    {
        public IEnumerable<string> LanguageCodeDashRegionCode { get; set; }
    }
}