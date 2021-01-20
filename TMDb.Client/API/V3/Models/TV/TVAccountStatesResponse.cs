using Newtonsoft.Json;
using TMDb.Client.API.V3.Models.TVEpisodes;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("watchlist")]
        public bool Watchlist { get; set; }

        [JsonConverter(typeof(RatedBoolConverter))]
        [JsonProperty("rated")]
        public TVRatingBoolUnion Rated { get; set; }
    }
}