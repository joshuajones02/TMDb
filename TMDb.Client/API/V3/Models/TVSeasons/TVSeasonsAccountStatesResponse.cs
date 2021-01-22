using Newtonsoft.Json;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    public class TVSeasonsAccountStatesResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual Result[] Results { get; set; }
    }

    public class Result
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("episode_number")]
        public virtual int EpisodeNumber { get; set; }

        [JsonConverter(typeof(RatedBoolConverter))]
        [JsonProperty("rated")]
        public virtual RatedBoolConverter Rated { get; set; }
    }
}