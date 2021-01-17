using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesImagesResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("stills")]
        public virtual IEnumerable<Image> Stills { get; set; }
    }
}