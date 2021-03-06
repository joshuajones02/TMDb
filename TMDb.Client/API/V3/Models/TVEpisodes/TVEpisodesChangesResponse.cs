﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    public class TVEpisodesChangesResponse : TMDbResponse
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
        public virtual JToken Value { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }
    }
}