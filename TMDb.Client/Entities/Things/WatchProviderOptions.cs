using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.Entities.Things
{
    public class WatchProviderOptions
    {
        [JsonProperty("link")]
        public Uri Link { get; set; }

        [JsonProperty(
            propertyName: "flatrate",
            NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WatchProvider> FlatRate { get; set; }

        [JsonProperty(
            propertyName: "rent",
            NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WatchProvider> Rent { get; set; }

        [JsonProperty(
            propertyName: "buy",
            NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<WatchProvider> Buy { get; set; }
    }
}