using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Entities;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class ListDetailsResponse : TMDbRequest
    {
        [JsonProperty("favorite_count")]
        public virtual int FavoriteCount { get; set; }

        [JsonProperty("item_count")]
        public virtual int ItemCount { get; set; }

        [JsonProperty("created_by")]
        public virtual string CreatedBy { get; set; }

        [JsonProperty("description")]
        public virtual string Description { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("items")]
        public virtual IEnumerable<ListDetailsItem> Items { get; set; }
    }

    public class ListDetailsItem : MovieMinified
    {
        [JsonProperty("media_type")]
        public virtual string MediaType { get; set; }
    }
}