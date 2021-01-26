using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.TVSeasons
{
    public class TVSeasonsImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("posters")]
        public virtual IEnumerable<Image> Posters { get; set; }
    }
}