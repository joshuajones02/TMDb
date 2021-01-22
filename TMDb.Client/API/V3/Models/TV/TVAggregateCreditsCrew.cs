using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVAggregateCreditsCrew : TVAggregateCreditsPersonBase
    {
        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("jobs")]
        public IEnumerable<TVAggregateCreditsCrewJob> Jobs { get; set; }
    }
}