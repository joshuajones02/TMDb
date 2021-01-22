using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Organizations;

namespace TMDb.Client.Api.V3.Models.Search
{
    public class SearchCompaniesResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<Company> Companies { get; set; }
    }
}