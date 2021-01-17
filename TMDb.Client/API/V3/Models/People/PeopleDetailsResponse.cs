using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.People
{
    public class PeopleDetailsResponse : TMDbResponse
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("popularity")]
        public virtual double? Popularity { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("known_for_department")]
        public virtual string KnownForDepartment { get; set; }

        [JsonProperty("biography")]
        public virtual string Biography { get; set; }

        [JsonProperty("place_of_birth")]
        public virtual string PlaceOfBirth { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("imdb_id")]
        public virtual string IMDbId { get; set; }

        [JsonProperty("homepage")]
        public virtual Uri Homepage { get; set; }

        [JsonProperty("birthday")]
        public virtual DateTime? Birthday { get; set; }

        [JsonProperty("deathday")]
        public virtual DateTime? Deathday { get; set; }

        [JsonProperty("gender")]
        public virtual Gender Gender { get; set; }

        [JsonProperty("also_known_as")]
        public virtual IEnumerable<string> Aliases { get; set; }
    }
}