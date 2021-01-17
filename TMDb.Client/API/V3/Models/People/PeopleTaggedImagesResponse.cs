using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities.Media;

namespace TMDb.Client.API.V3.Models.People
{
    public class PeopleTaggedImagesResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("profiles")]
        public IEnumerable<Image> Profiles { get; set; }
    }
}