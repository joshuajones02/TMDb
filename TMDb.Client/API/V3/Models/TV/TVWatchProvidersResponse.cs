using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TMDb.Client.Entities.Things;

namespace TMDb.Client.API.V3.Models.TV
{
    public class TVWatchProvidersResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual WatchProviderList Results { get; set; }
    }
}