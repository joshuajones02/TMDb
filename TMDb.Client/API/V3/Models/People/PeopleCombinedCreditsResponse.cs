using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleCombinedCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonConverter(typeof(MovieTVCreditsCastConverter))]
        [JsonProperty("cast")]
        public virtual IEnumerable<MovieTVCreditsCastUnion> Cast { get; set; }

        [JsonConverter(typeof(MovieTVCreditsCrewConverter))]
        [JsonProperty("crew")]
        public virtual IEnumerable<MovieTVCreditsCrewUnion> Crew { get; set; }
    }
}