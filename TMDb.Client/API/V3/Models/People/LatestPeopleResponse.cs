using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.People
{
    public class LatestPeopleResponse : TMDbResponse
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("popularity")]
        public int? Popularity { get; set; }

        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("imdb_id")]
        public string IMDbId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonProperty("birthday")]
        public DateTime? Birthday { get; set; }

        [JsonProperty("deathday")]
        public DateTime? Deathday { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("also_known_as")]
        public IEnumerable<string> AlsoKnownAs { get; set; }
    }
}