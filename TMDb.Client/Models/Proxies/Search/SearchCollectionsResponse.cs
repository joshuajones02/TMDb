using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.Search
{
    public class SearchCollectionsResponse : TMDbResponse
    {
        public virtual IEnumerable<MinifiedCollection> Collections { get; set; }
    }
}