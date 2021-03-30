﻿using Newtonsoft.Json;

namespace TMDb.Client.Entities.Things
{
    public class CollectionMinified
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("backdrop_path")]
        public virtual string BackdropPath { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }
    }
}