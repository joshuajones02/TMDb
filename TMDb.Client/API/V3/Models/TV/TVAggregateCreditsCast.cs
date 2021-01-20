using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVAggregateCreditsCast : TVAggregateCreditsPersonBase
    {
        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<TVAggregateCreditsCastRole> Roles { get; set; }
    }
}