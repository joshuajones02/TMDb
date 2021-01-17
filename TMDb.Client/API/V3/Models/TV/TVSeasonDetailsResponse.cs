using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVSeasonDetailsResponse : TMDbResponse
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("id")]
        public int SeasonId { get; set; }

        [JsonProperty("season_number")]
        public int SeasonNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("air_date")]
        public DateTime AirDate { get; set; }

        [JsonProperty("episodes")]
        public IEnumerable<Episode> Episodes { get; set; }
    }
}