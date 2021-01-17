using Newtonsoft.Json;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsAccountStatesResponse : TMDbResponse
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

        [JsonConverter(typeof(RatedBoolUnionConverter))]
        [JsonProperty("rated")]
        public virtual RatedUnion Rated { get; set; }
    }
}