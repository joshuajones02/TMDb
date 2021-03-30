using Newtonsoft.Json;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    public class TVSeasonsAccountStatesResultItem
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("episode_number")]
        [JsonRequired]
        public virtual int? EpisodeNumber { get; set; }

        [JsonProperty("rated")]
        public virtual MediaRating Rated { get; set; }
    }
}