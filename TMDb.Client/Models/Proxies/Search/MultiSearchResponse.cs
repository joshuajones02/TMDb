using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Search
{
    public class MultiSearchResponse : TMDbResponse
    {
        public virtual IEnumerable<SearchResult> Results { get; set; }
    }
}