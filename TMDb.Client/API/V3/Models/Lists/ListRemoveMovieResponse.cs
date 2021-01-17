using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Lists
{
    [Obsolete("// TODO: Revisit once TMDb Response has been refactored")]
    public class ListRemoveMovieResponse
    {
        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }
    }
}