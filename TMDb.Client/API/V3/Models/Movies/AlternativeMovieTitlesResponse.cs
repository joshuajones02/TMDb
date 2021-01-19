using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TMDb.Client.API.V3.Models.Movies
{
    public class AlternativeMovieTitlesResponse : TMDbResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("titles")]
        public IEnumerable<Title> Titles { get; set; }
    }

    public partial class Title
    {
        [JsonProperty("iso_3166_1")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("title")]
        public string TitleTitle { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
