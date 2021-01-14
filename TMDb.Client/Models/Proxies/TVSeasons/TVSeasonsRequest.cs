﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Models.Proxies.TVSeasons
{
    public class TVSeasonsRequest : TMDbRequest
    {
        [JsonIgnore]
        [Required]
        [StringFormatParameter("tv_id")]
        public virtual int? TvId { get; set; }

        [JsonIgnore]
        [Required]
        [StringFormatParameter("season_number")]
        public virtual int? SeasonNumber { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        [Obsolete("// TODO: Refactor, some endpoints don't accept language (i.e. DeleteTVEpisodeRating)")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}