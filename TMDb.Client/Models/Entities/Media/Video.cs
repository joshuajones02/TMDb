﻿using Newtonsoft.Json;

namespace TMDb.Client.Entities.Media
{
    public class Video
    {
        [JsonProperty("size")]
        public virtual int Size { get; set; }

        [JsonProperty("id")]
        public virtual string Id { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("iso_3166_1")]
        public virtual string CountryCode { get; set; }

        [JsonProperty("key")]
        public virtual string Key { get; set; }

        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("site")]
        public virtual string Site { get; set; }

        [JsonProperty("type")]
        public virtual string Type { get; set; }
    }
}