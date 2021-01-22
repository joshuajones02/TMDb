using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.JsonConverters;
using TMDb.Client.Unions;

namespace TMDb.Client.Api.V3.Models.Trending
{
    public class TrendingResponse : TMDbCollectionResponse
    {
        [JsonConverter(typeof(TrendingMovieTVConverter))]
        [JsonProperty("results")]
        public virtual IEnumerable<TrendingMovieTVUnion> Results { get; set; }
    }
}