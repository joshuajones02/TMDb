using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;
using TMDb.Client.JsonConverters;

namespace TMDb.Client.API.V3.Models.Movie
{
    public class DiscoverMovieRequest : TMDbRequest
    {
        public DiscoverMovieRequest(int? page)
        {
            Page = page ?? 1;
        }

        [ApiParameter(
            Name = "include_adult",
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeAdult { get; set; }

        [ApiParameter(
            Name = "include_video",
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeVideo { get; set; }

        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "primary_release_year",
            ParameterType = ParameterType.Query)]
        public virtual int? PrimaryReleaseYear { get; set; }

        [ApiParameter(
            Name = "with_release_type",
            ParameterType = ParameterType.Query)]
        public virtual int? WithReleaseType { get; set; }

        [ApiParameter(
            Name = "with_runtime.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? WithRuntimeGte { get; set; }

        [ApiParameter(
            Name = "with_runtime.lte",
            ParameterType = ParameterType.Query)]
        public virtual int? WithRuntimeLte { get; set; }

        [ApiParameter(
            Name = "year",
            ParameterType = ParameterType.Query)]
        public virtual int? Year { get; set; }

        [ApiParameter(
            Name = "vote_count.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteCountGte { get; set; }

        [ApiParameter(
            Name = "vote_count.lte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteCountLte { get; set; }

        [ApiParameter(
            Name = "vote_average.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteAverageGte { get; set; }

        [ApiParameter(
            Name = "vote_average.lte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteAverageLte { get; set; }

        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        [ApiParameter(
            Name = "with_original_language",
            ParameterType = ParameterType.Query)]
        public virtual string WithOriginalLanguage { get; set; }

        [ApiParameter(
            Name = "region",
            ParameterType = ParameterType.Query)]
        public virtual string Region { get; set; }

        [ApiParameter(
            Name = "certification_country",
            ParameterType = ParameterType.Query)]
        public virtual string CertificationCountry { get; set; }

        [ApiParameter(
            Name = "certification",
            ParameterType = ParameterType.Query)]
        public virtual string Certification { get; set; }

        [ApiParameter(
            Name = "certification.lte",
            ParameterType = ParameterType.Query)]
        public virtual string CertificationLte { get; set; }

        [ApiParameter(
            Name = "certification.gte",
            ParameterType = ParameterType.Query)]
        public virtual string CertificationGte { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_cast",
            ParameterType = ParameterType.Query)]
        public virtual string WithCast { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_crew",
            ParameterType = ParameterType.Query)]
        public virtual string WithCrew { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_people",
            ParameterType = ParameterType.Query)]
        public virtual string WithPeople { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_companies",
            ParameterType = ParameterType.Query)]
        public virtual string WithCompanies { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_genres",
            ParameterType = ParameterType.Query)]
        public virtual string Genres { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_genres",
            ParameterType = ParameterType.Query)]
        public virtual string GenreExclusions { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "with_keywords",
            ParameterType = ParameterType.Query)]
        public virtual string WithKeywords { get; set; }

        /// <summary> Comma separated indicates an 'AND' query, while a pipe(|) separated value indicates an 'OR'. </summary>
        [ApiParameter(
            Name = "without_keywords",
            ParameterType = ParameterType.Query)]
        public virtual string WithoutKeywords { get; set; }

        [ApiParameter(
            Name = "primary_release_date.gte",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? PrimaryReleaseDateGte { get; set; }

        [ApiParameter(
            Name = "primary_release_date.lte",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? PrimaryReleaseDateLte { get; set; }

        [ApiParameter(
            Name = "release_date.gte",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? ReleaseDateGte { get; set; }

        [ApiParameter(
            Name = "release_date.lte",
            ParameterType = ParameterType.Query)]
        public virtual DateTime? ReleaseDateLte { get; set; }

        //[JsonConverter(typeof(StringEnumConverter))]
        [JsonConverter(typeof(EnumDescriptionConverter))]
        [ApiParameter(
            Name = "sort_by",
            ParameterType = ParameterType.Query)]
        public virtual DiscoverMovieSortBy SortBy { get; set; }
    }
}