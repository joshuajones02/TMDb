using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.People;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    public enum Department { Acting, Art, Camera, CostumeMakeUp, Creator, Directing, Editing, Production, Sound, Writing }

    public class TVSeasonsAggregateCreditsResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("cast")]
        public virtual IEnumerable<TVSeasonsAggregateCreditsCast> Cast { get; set; }

        [JsonProperty("crew")]
        public virtual IEnumerable<Crew> Crew { get; set; }
    }

    public class TVSeasonsAggregateCreditsCast : TVSeasonsAggregateCreditsMember
    {
        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("roles")]
        public virtual IEnumerable<TVSeasonsAggregateCreditsRole> Roles { get; set; }
    }

    public class TVSeasonsAggregateCreditsCrew : TVSeasonsAggregateCreditsMember
    {
        [JsonProperty("order")]
        public virtual int? Order { get; set; }

        [JsonProperty("department")]
        public virtual Department? Department { get; set; }

        [JsonProperty("jobs")]
        public virtual IEnumerable<TVSeasonsAggregateCreditsJob> Jobs { get; set; }
    }

    public abstract class TVSeasonsAggregateCreditsMember
    {
        [JsonProperty("adult")]
        public virtual bool Adult { get; set; }

        [JsonProperty("popularity")]
        public virtual double Popularity { get; set; }

        [JsonProperty("gender")]
        public virtual int Gender { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("total_episode_count")]
        public virtual int TotalEpisodeCount { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("original_name")]
        public virtual string OriginalName { get; set; }

        [JsonProperty("profile_path")]
        public virtual string ProfilePath { get; set; }

        [JsonProperty("known_for_department")]
        public virtual Department KnownForDepartment { get; set; }
    }

    public class TVSeasonsAggregateCreditsJob : TVSeasonsAggregateCreditsGig
    {
        [JsonProperty("job")]
        public virtual string Job { get; set; }
    }

    public class TVSeasonsAggregateCreditsRole : TVSeasonsAggregateCreditsGig
    {
        [JsonProperty("character")]
        public virtual string Character { get; set; }
    }

    public abstract class TVSeasonsAggregateCreditsGig
    {
        [JsonProperty("credit_id")]
        public virtual string CreditId { get; set; }

        [JsonProperty("episode_count")]
        public virtual int EpisodeCount { get; set; }
    }
}