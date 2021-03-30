using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.JsonConverters;
using TMDb.Client.Unions;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PersonMinified
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonConverter(typeof(PopularPeopleKnownForMovieTVConverter))]
        [JsonProperty("known_for")]
        public virtual IEnumerable<PopularPeopleKnownForMovieTVUnion> KnownFor { get; set; }
    }
}