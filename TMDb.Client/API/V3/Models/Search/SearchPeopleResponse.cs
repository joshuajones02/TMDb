using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.People;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchPeopleResponse : TMDbCollectionResponse
    {
        [JsonProperty("results")]
        public virtual IEnumerable<PersonMinified> Results { get; set; }
    }
}