using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.People
{
    public class PeopleMovieCreditsResponse : TMDbResponse
    {
        [JsonProperty("cast")]
        public virtual IEnumerable<PeopleMovieCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<PeopleMovieCreditsCrew> Crew { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}