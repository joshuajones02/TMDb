using Newtonsoft.Json;
using System;

namespace TMDb.Client.Models.Proxies.TVEpisodes
{
    public class TVEpisodesChangesRequest : TMDbRequest
    {
        [JsonProperty("page")]
        public virtual int Page { get; set; }

        [JsonProperty("episode_id")]
        [JsonRequired]
        public virtual int EpisodeId { get; set; }

        [JsonProperty(
            propertyName: "start_date",
            NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTime? StartDate { get; set; }

        [JsonProperty(
            propertyName: "end_date",
            NullValueHandling = NullValueHandling.Ignore)]
        [JsonRequired]
        public virtual DateTime? EndDate { get; set; }
    }
}