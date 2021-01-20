using Newtonsoft.Json;
using System.Collections.Generic;

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
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [JsonProperty("iso_3166_1")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("title")]
        public string TitleTitle { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}