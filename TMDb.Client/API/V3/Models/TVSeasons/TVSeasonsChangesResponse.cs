using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.TVSeasons
{
    public class TVSeasonsChangesResponse : TMDbResponse
    {
        [JsonProperty("changes")]
        public virtual IEnumerable<TVSeasonsChange> Changes { get; set; }
    }

    public class TVSeasonsChange
    {
        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("items")]
        public virtual IEnumerable<TVSeasonsChangeItem> Items { get; set; }
    }

    public class TVSeasonsChangeItem
    {
        [JsonProperty("id")]
        public virtual string Id { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string Language { get; set; }

        [JsonProperty("original_value")]
        public virtual string OriginalValue { get; set; }

        [JsonProperty("time")]
        public virtual string Time { get; set; }

        [JsonProperty("value")]
        public virtual TVSeasonsChangeItemValue Value { get; set; }

        [JsonProperty("action")]
        public virtual ChangeAction Action { get; set; }
    }

    public class TVSeasonsChangeItemValue
    {
        [JsonProperty("episode_id")]
        public virtual int EpisodeId { get; set; }

        [JsonProperty("episode_number")]
        public virtual int EpisodeNumber { get; set; }
    }
}