using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Models;

namespace TMDb.Client.API.V3.Models.Lists
{
    public class ListDetailsResponse : TMDbRequest
    {
        [JsonProperty("favorite_count")]
        public int FavoriteCount { get; set; }

        [JsonProperty("item_count")]
        public int ItemCount { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iso_639_1")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("items")]
        public IEnumerable<ListDetailsItem> Items { get; set; }
    }

    public class ListDetailsItem : MovieMinified
    {
        [JsonProperty("media_type")]
        public string MediaType { get; set; }
    }
}