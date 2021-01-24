using System;
using System.Collections.Generic;

namespace TMDb.Client.Entities.Media
{
    public interface ITVMinified
    {
        double? Popularity { get; set; }
        double? VoteAverage { get; set; }
        int Id { get; set; }
        int? VoteCount { get; set; }

        string BackdropPath { get; set; }
        string Name { get; set; }
        string OriginalLanguage { get; set; }
        string OriginalName { get; set; }
        string Overview { get; set; }
        string PosterPath { get; set; }

        DateTime? FirstAirDate { get; set; }

        IEnumerable<int> GenreIds { get; set; }
        IEnumerable<string> OriginCountry { get; set; }
    }
}