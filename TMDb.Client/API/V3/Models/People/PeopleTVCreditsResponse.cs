using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleTVCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("cast")]
        public virtual IEnumerable<PeopleTVCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<PeopleTVCreditsCrew> Crew { get; set; }
    }
}