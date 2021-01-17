using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.People
{
    public class PopularPeopleResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public IEnumerable<PopularPeopleResult> Results { get; set; }
    }
}