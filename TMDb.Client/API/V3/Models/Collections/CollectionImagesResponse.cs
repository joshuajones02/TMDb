using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.Collections
{
    public class CollectionImagesResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("backdrops")]
        public virtual IEnumerable<Image> Backdrops { get; set; }

        [JsonProperty("posters")]
        public virtual IEnumerable<Image> Posters { get; set; }
    }
}