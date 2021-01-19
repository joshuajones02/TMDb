using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieAccountStatesResponse : TMDbResponse
    {
        [JsonProperty("favorite")]
        public virtual bool Favorite { get; set; }

        [JsonProperty("watchlist")]
        public virtual bool Watchlist { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("rated")]
        public virtual Entities.Things.TVEpisodeRating Rated { get; set; }
    }
}
