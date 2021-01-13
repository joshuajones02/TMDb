using Newtonsoft.Json;
using System;

namespace TMDb.Client.Models
{
    [Obsolete("TODO: Put the following property members into a child class, not all responses are collections")]
    public class TMDbResponse
    {
        [JsonProperty("page")]
        public virtual int Page { get; set; }

        [JsonProperty("total_pages")]
        public virtual int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public virtual int TotalResults { get; set; }
    }
}