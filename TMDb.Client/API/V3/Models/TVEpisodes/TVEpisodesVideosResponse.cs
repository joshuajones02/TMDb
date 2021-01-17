using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.TVSeasons;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesVideosResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        public virtual IEnumerable<TVSeasonsVideosResult> Videos { get; set; }
    }
}