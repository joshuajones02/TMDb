using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Find
{
    public class FindByIdTVResult : FindByIdMediaItem
    {
        [JsonProperty("original_title")]
        [Obsolete("Do the same as released date or follow composition over inheritance??")]
        public virtual string OriginalTitle { get; set; }

        [JsonProperty("title")]
        [Obsolete("Do the same as released date or follow composition over inheritance??")]
        public virtual string Title { get; set; }

        [JsonProperty("first_air_date")]
        [Obsolete("Apply this over project or follow composition over inheritance??")]
        public override DateTime? ReleaseDate { get; set; }

        [JsonProperty("origin_country")]
        public virtual IEnumerable<string> OriginCountry { get; set; }
    }
}