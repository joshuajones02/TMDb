using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    public class TVEpisodesChangesResponse : TMDbCollectionResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<TVEpisodesChange> Changes { get; set; }
    }

    public class TVEpisodesChange
    {
        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("items")]
        public virtual IEnumerable<TVEpisodeChangeItem> Items { get; set; }
    }

    public class TVEpisodeChangeItem
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("action")]
        public virtual string Action { get; set; }

        [JsonProperty("time")]
        public virtual string Time { get; set; }

        [JsonProperty("value")]
        public virtual string Value { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("original_value")]
        public virtual string OriginalValue { get; set; }
    }
}