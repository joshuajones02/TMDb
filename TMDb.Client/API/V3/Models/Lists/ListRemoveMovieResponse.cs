using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Lists
{
    [Obsolete("// TODO: Revisit once TMDb Response has been refactored")]
    public class ListRemoveMovieResponse
    {
        [JsonProperty("status_code")]
        public virtual int StatusCode { get; set; }

        [JsonProperty("status_message")]
        public virtual string StatusMessage { get; set; }
    }
}