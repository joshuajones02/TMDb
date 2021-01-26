using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("stills")]
        public virtual IEnumerable<Image> Stills { get; set; }
    }
}