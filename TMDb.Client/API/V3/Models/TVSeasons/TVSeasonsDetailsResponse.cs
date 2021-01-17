using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsDetailsResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("season_number")]
        public virtual int SeasonNumber { get; set; }

        [JsonProperty("_id")]
        public virtual string SeasonId { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("overview")]
        public virtual string Overview { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("air_date")]
        public virtual DateTime? AirDate { get; set; }

        [JsonProperty("episodes")]
        public virtual IEnumerable<Episode> Episodes { get; set; }
    }
}