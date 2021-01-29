using Newtonsoft.Json;
using TMDb.Client.Api.V3.Models.Movies;

namespace TMDb.Client.Api.V3.Models.TV
{
    public class TVReviewsResponse : TMDbCollectionResponse<MovieReviewsItem>
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }
    }
}