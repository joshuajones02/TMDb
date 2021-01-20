using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.API.V3.Models.Movies;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVReviewsResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        [Obsolete("// TODO: Rename and move to entities")]
        public virtual IEnumerable<MovieReviewsItem> Results { get; set; }
    }
}