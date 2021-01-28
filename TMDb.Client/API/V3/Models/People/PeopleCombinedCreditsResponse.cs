using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Api.V3.Models.Trending;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleCombinedCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        // TODO: Replace with proper model
        [JsonProperty("cast")]
        public virtual IEnumerable<TrendingResultItem> Cast { get; set; }

        // TODO: Replace with proper model
        [JsonProperty("crew")]
        public virtual IEnumerable<TrendingResultItem> Crew { get; set; }
    }
}