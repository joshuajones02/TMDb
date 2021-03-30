using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Entities.Things
{
    public class WatchProviderOptions
    {
        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty("flatrate")]
        public IEnumerable<WatchProvider> FlatRate { get; set; }

        [JsonProperty("rent")]
        public IEnumerable<WatchProvider> Rent { get; set; }

        [JsonProperty("buy")]
        public IEnumerable<WatchProvider> Buy { get; set; }
    }
}