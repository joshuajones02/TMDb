using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PopularPeopleResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public IEnumerable<PersonMinified> Results { get; set; }
    }
}