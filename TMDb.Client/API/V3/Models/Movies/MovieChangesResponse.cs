using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieChangesResponse : TMDbResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<MovieChangeResult> Changes { get; set; }
    }

    public class MovieChangeResult
    {
        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("items")]
        public virtual IEnumerable<MovieChangeItem> Items { get; set; }
    }

    public class MovieChangeItem
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("action")]
        public virtual string Action { get; set; }

        [JsonProperty("time")]
        public virtual string Time { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("value")]
        public virtual string Value { get; set; }

        [JsonProperty("original_value")]
        public virtual string OriginalValue { get; set; }
    }
}