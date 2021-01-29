using Newtonsoft.Json;
using TMDb.Client.Api.V3.Models.TVEpisodes;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    public class TVSeasonsAccountStatesResponse : TMDbCollectionResponse<TVSeasonsAccountStatesResultItem>
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }

    public class TVSeasonsAccountStatesResultItem
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("episode_number")]
        [JsonRequired]
        public virtual int? EpisodeNumber { get; set; }

        [JsonConverter(typeof(RatedBoolConverter))]
        [JsonProperty("rated")]
        public virtual TVRatingBoolUnion Rated { get; set; }
    }
}