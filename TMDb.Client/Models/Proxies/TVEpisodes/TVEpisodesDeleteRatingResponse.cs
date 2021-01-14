﻿using Newtonsoft.Json;
using System;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    [Obsolete("Merge with TVEpisodesPostRatingResponse")]
    public class TVEpisodesDeleteRatingResponse : TMDbResponse
    {
        [JsonProperty("status_code")]
        public virtual int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public virtual int StatusMessage { get; set; }
    }
}