﻿using Newtonsoft.Json;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsRequest : TMDbRequest
    {
        [JsonProperty("tv_id")]
        [JsonRequired]
        public virtual int TvId { get; set; }

        [JsonProperty("season_number")]
        [JsonRequired]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string LanguageAbbreviation { get; set; }
    }
}