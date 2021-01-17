using Newtonsoft.Json;
using System.Collections.Generic;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchMediaResult : SearchResult
    {
        [ApiParameter(
            Name = "vote_average")]
        public double? VoteAverage { get; set; }

        [ApiParameter(
            Name = "vote_count")]
        public int VoteCount { get; set; }

        [ApiParameter(
            Name = "backdrop_path")]
        public string BackdropPath { get; set; }

        [ApiParameter(
            Name = "original_language")]
        public string OriginalLanguage { get; set; }

        [ApiParameter(
            Name = "overview")]
        public string Overview { get; set; }

        [ApiParameter(
            Name = "poster_path")]
        public string PosterPath { get; set; }

        [ApiParameter(
            Name = "genre_ids")]
        public IEnumerable<int> GenreIds { get; set; }
    }
}