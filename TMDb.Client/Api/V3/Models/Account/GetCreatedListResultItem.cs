using Newtonsoft.Json;

namespace TMDb.Client.Api.V3.Models.Account
{
    public class GetCreatedListResultItem
    {
        [JsonProperty("description")]
        public virtual string Description { get; set; }

        [JsonProperty("favorite_count")]
        public virtual int? FavoriteCount { get; set; }

        [JsonProperty("id")]
        public virtual int Id { get; set; }

        [JsonProperty("item_count")]
        public virtual int? ItemCount { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("list_type")]
        public virtual string ListType { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("poster_path")]
        public virtual string PosterPath { get; set; }
    }
}