using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVCreditsResponse : TMDbResponse
    {
        [JsonProperty("cast")]
        public virtual IEnumerable<TVCreditsResponseCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<TVCreditsResponseCast> Crew { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }

    [Obsolete("// TODO: Refactor cast/crew TVCreditsResponse")]
    public class TVCreditsResponseCast
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("gender")]
        public virtual Gender Gender { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("known_for_department")]
        public virtual string KnownForDepartment { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("character", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Character { get; set; }

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public virtual int? Order { get; set; }

        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Department { get; set; }

        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Job { get; set; }
    }
}