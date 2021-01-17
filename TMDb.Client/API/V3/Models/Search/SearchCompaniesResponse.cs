using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchCompaniesResponse : TMDbResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Company> Companies { get; set; }
    }
}