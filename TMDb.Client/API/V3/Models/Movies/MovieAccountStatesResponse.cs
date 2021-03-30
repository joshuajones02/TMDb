using Newtonsoft.Json;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.Api.V3.Models.Movies
{
    public class MovieAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("favorite")]
        public virtual bool? Favorite { get; set; }

        [JsonProperty("watchlist")]
        public virtual bool? Watchlist { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("rated")]
        public virtual MediaRating Rated { get; set; }
    }
}