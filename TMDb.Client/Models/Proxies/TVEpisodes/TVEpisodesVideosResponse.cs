using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models.Proxies.TVSeasons;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesVideosResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        public virtual IEnumerable<TVSeasonsVideosResult> Videos { get; set; }
    }
}