using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.Movies
{
    public class MovieReleaseDatesResult
    {
        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("release_dates")]
        public virtual IEnumerable<MovieReleaseDatesItem> ReleaseDates { get; set; }
    }
}