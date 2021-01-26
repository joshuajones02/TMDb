using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Api.V3.Models.TVSeasons;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesVideosResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        public virtual IEnumerable<TVSeasonsVideosResult> Videos { get; set; }
    }
}