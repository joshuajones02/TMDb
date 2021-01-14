﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsImagesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("posters")]
        public virtual IEnumerable<Image> Posters { get; set; }
    }
}