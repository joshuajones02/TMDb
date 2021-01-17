﻿using Newtonsoft.Json;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesAccountStatesResponse : TMDbCollectionResponse
    {
        [JsonProperty("favorite")]
        public virtual bool Favorite { get; set; }

        [JsonProperty("watchlist")]
        public virtual bool Watchlist { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonConverter(typeof(RatedBoolConverter))]
        [JsonProperty("rated")]
        public virtual TVEpisodeRatingBoolUnion Rated { get; set; }
    }
}