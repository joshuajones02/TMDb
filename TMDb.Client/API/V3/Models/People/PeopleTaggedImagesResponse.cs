using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.Api.V3.Models.People
{
    public class PeopleTaggedImagesResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<PeopleTaggedImagesResult> Results { get; set; }
    }

    public class PeopleTaggedImagesResult : Image
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("image_type")]
        public virtual string ImageType { get; set; }

        [JsonProperty("media_type")]
        public virtual string MediaType { get; set; }

        [JsonProperty("media")]
        public virtual MovieMinified Media { get; set; }
    }
}