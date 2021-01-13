using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("cast")]
        public virtual IEnumerable<TVSeasonsCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<TVSeasonsCreditsCrew> Crew { get; set; }
    }

    public class TVSeasonsCreditsCast : TVSeasonsCreditsCrew
    {
        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("character")]
        public virtual string Character { get; set; }
    }

    public class TVSeasonsCreditsCrew
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("gender")]
        public virtual int? Gender { get; set; }

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

        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }

        [JsonProperty("job")]
        public virtual string Job { get; set; }

        [JsonProperty("department")]
        public virtual string Department { get; set; }
    }
}