using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchKeywordsResponse : TMDbResponse
    {
        public IEnumerable<Keyword> Keywords { get; set; }
    }
}