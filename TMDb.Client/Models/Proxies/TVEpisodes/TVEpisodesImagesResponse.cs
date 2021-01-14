using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("stills")]
        public virtual IEnumerable<Image> Stills { get; set; }
    }
}