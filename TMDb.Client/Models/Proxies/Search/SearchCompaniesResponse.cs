using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchCompaniesResponse : TMDbResponse
    {
        public virtual IEnumerable<Company> Companies { get; set; }
    }
}