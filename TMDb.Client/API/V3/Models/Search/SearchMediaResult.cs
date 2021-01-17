using Newtonsoft.Json;
using System.Collections.Generic;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchMediaResult : SearchResult
    {
        [ApiParameter(
            Name = "vote_average",
            ParameterType = ParameterType.Query)]
        public virtual double? VoteAverage { get; set; }

        [ApiParameter(
            Name = "vote_count",
            ParameterType = ParameterType.Query)]
        public virtual int VoteCount { get; set; }

        [ApiParameter(
            Name = "backdrop_path",
            ParameterType = ParameterType.Query)]
        public virtual string BackdropPath { get; set; }

        [ApiParameter(
            Name = "original_language",
            ParameterType = ParameterType.Query)]
        public virtual string OriginalLanguage { get; set; }

        [ApiParameter(
            Name = "overview",
            ParameterType = ParameterType.Query)]
        public virtual string Overview { get; set; }

        [ApiParameter(
            Name = "poster_path",
            ParameterType = ParameterType.Query)]
        public virtual string PosterPath { get; set; }

        [ApiParameter(
            Name = "genre_ids",
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> GenreIds { get; set; }
    }
}