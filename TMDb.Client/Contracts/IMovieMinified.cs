using System;
using System.Collections.Generic;

namespace TMDb.Client.Contracts
{
    public interface IMovieMinified
    {
        bool Adult { get; set; }
        bool Video { get; set; }

        double? Popularity { get; set; }
        double? VoteAverage { get; set; }

        int Id { get; set; }
        int VoteCount { get; set; }

        string BackdropPath { get; set; }
        string LanguageAbbreviation { get; set; }
        string OriginalTitle { get; set; }
        string Overview { get; set; }
        string PosterPath { get; set; }
        string Title { get; set; }

        DateTime? ReleaseDate { get; set; }
        [Obsolete("// TODO: Create JSON Converter that will use Genres to fill data")]
        IEnumerable<int> GenreIds { get; set; }
    }
}