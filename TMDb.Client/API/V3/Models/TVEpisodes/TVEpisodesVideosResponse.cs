using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesVideosResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        public virtual IEnumerable<TVSeasonsVideosResult> Videos { get; set; }
    }
}