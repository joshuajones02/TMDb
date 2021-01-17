using Newtonsoft.Json;
using System;
using TMDb.Client.Enums;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class DiscoverMovieRequest : TMDbRequest
    {
        public DiscoverMovieRequest() : this(null)
        {
        }

        public DiscoverMovieRequest(int? page)
        {
            Page = page ?? 1;
        }

        [ApiParameter(
            Name = "include_adult")]
        public bool? IncludeAdult { get; set; }

        [ApiParameter(
            Name = "include_video")]
        public bool? IncludeVideo { get; set; }

        [ApiParameter(
            Name = "page")]
        [JsonRequired]
        public int Page { get; set; }

        [ApiParameter(
            Name = "primary_release_year")]
        public int? PrimaryReleaseYear { get; set; }

        [ApiParameter(
            Name = "with_release_type")]
        public int? WithReleaseType { get; set; }

        [ApiParameter(
            Name = "with_runtime.gte")]
        public int? WithRuntimeGte { get; set; }

        [ApiParameter(
            Name = "with_runtime.lte")]
        public int? WithRuntimeLte { get; set; }

        [ApiParameter(
            Name = "year")]
        public int? Year { get; set; }

        [ApiParameter(
            Name = "vote_count.gte")]
        public int? VoteCountGte { get; set; }

        [ApiParameter(
            Name = "vote_count.lte")]
        public int? VoteCountLte { get; set; }

        [ApiParameter(
            Name = "vote_average.gte")]
        public int? VoteAverageGte { get; set; }

        [ApiParameter(
            Name = "vote_average.lte")]
        public int? VoteAverageLte { get; set; }

        [ApiParameter(
            Name = "language")]
        public string Language { get; set; }

        [ApiParameter(
            Name = "with_original_language")]
        public string WithOriginalLanguage { get; set; }

        [ApiParameter(
            Name = "region")]
        public string Region { get; set; }

        [ApiParameter(
            Name = "certification_country")]
        public string CertificationCountry { get; set; }

        [ApiParameter(
            Name = "certification")]
        public string Certification { get; set; }

        [ApiParameter(
            Name = "certification.lte")]
        public string CertificationLte { get; set; }

        [ApiParameter(
            Name = "certification.gte")]
        public string CertificationGte { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_cast")]
        public string WithCast { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_crew")]
        public string WithCrew { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_people")]
        public string WithPeople { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_companies")]
        public string WithCompanies { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_genres")]
        public string Genres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_genres")]
        public string GenreExclusions { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_keywords")]
        public string WithKeywords { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_keywords")]
        public string WithoutKeywords { get; set; }

        [ApiParameter(
            Name = "primary_release_date.gte")]
        public DateTime? PrimaryReleaseDateGte { get; set; }

        [ApiParameter(
            Name = "primary_release_date.lte")]
        public DateTime? PrimaryReleaseDateLte { get; set; }

        [ApiParameter(
            Name = "release_date.gte")]
        public DateTime? ReleaseDateGte { get; set; }

        [ApiParameter(
            Name = "release_date.lte")]
        public DateTime? ReleaseDateLte { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [ApiParameter(
            Name = "sort_by")]
        public DiscoverMovieSortBy SortBy { get; set; }
    }
}