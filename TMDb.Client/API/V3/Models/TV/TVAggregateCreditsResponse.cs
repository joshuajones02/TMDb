using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVAggregateCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cast")]
        public IEnumerable<TVAggregateCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public IEnumerable<TVAggregateCreditsCrew> Crew { get; set; }
    }
}