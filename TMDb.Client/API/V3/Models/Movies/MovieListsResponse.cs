using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieListsResponse : TMDbCollectionResponse
    {
        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("results")]
        public virtual IEnumerable<MovieListItem> Results { get; set; }
    }

    public class MovieListItem
    {
        [JsonProperty("favorite_count")]
        public virtual int? FavoriteCount { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("item_count")]
        public virtual int? ItemCount { get; set; }

        [JsonProperty("description")]
        public virtual string Description { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }

        [JsonProperty("list_type")]
        public virtual MediaType ListType { get; set; }
    }
}