using Newtonsoft.Json;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("watchlist")]
        public bool Watchlist { get; set; }

        [JsonProperty("rated")]
        public MediaRating Rated { get; set; }
    }
}