using Newtonsoft.Json;
using System;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class MovieReleaseDatesItem
    {
        [JsonProperty("type")]
        public virtual int Type { get; set; }

        [JsonProperty("certification")]
        public virtual string Certification { get; set; }

        [JsonProperty("iso_639_1")]
        public virtual string LanguageAbbreviation { get; set; }

        [JsonProperty("note")]
        public virtual string Note { get; set; }

        [JsonProperty("release_date")]
        public virtual DateTime? ReleaseDate { get; set; }
    }
}