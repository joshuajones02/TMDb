using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.People
{
    public abstract class KnownForItemBase
    {
        [JsonProperty("popularity")]
        public double? Popularity { get; set; }

        [JsonProperty("vote_average")]
        public double? VoteAverage { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public string LanguageAbbreviation { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("media_type")]
        public MediaType MediaType { get; set; }

        [JsonProperty("genre_ids")]
        public IEnumerable<int> GenreIds { get; set; }
    }
}