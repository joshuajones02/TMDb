using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.JsonConverters;
using TMDb.Client.Unions;

namespace TMDb.Client.API.V3.Models.People
{
    public class PopularPeopleResult
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonConverter(typeof(PopularPeopleKnownForMovieTVConverter))]
        [JsonProperty("known_for")]
        public IEnumerable<PopularPeopleKnownForMovieTVUnion> KnownFor { get; set; }
    }
}