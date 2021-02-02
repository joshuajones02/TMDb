using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;

namespace TMDb.Client.Api.V3.Models.Discover
{
    /// <summary>
    /// Discover movies by different types of data like average rating,
    /// number of votes, genres and certifications. You can get a valid
    /// list of certifications from the certifications list method
    /// (https://developers.themoviedb.org/3/certifications/get-movie-certifications).
    ///
    /// Discover also supports a nice list of sort options.See below
    /// for all of the available options.
    ///
    /// Please note, when using certification \ certification.lte you
    /// must also specify certification_country.These two parameters
    /// work together in order to filter the results.You can only
    /// filter results with the countries we have added to our.
    ///
    /// If you specify the region parameter, the regional release
    /// date will be used instead of the primary release date.
    /// The date returned will be the first date based on your query
    /// (ie. if a with_release_type is specified). It's important
    /// to note the order of the release types that are used.
    /// Specifying "2|3" would return the limited theatrical release
    /// date as opposed to "3|2" which would return the theatrical
    /// date.
    ///
    /// Also note that a number of filters support being comma(,) or
    /// pipe(|) separated.Comma's are treated like an AND and query
    /// while pipe's are an OR.
    ///
    /// Some examples of what can be done with discover can be found
    /// https://www.themoviedb.org/documentation/api/discover.
    /// </summary>
    [ApiGetEndpoint("/discover/movie")]
    public class DiscoverMovieRequest : TMDbRequest
    {
        public DiscoverMovieRequest()
        {
            Page = 1;
        }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        ///     pattern: ^[A-Z]{2}$
        /// </summary>
        [ApiParameter(
            Name = "region",
            ParameterType = ParameterType.Query)]
        public virtual string RegionCountryCode { get; set; }

        /// <summary>
        /// Choose from one of the many available sort options.
        ///
        ///     Allowed Values:
        ///         popularity.asc           , popularity.desc,
        ///         release_date.asc         , release_date.desc,
        ///         revenue.asc              , revenue.desc,
        ///         primary_release_date.asc , primary_release_date.desc,
        ///         original_title.asc       , original_title.desc,
        ///         vote_average.asc         , vote_average.desc,
        ///         vote_count.asc           , vote_count.desc
        ///     default: popularity.desc
        /// </summary>
        [ApiParameter(
            Name = "sort_by",
            Option = SerializationOption.EnumDescription,
            ParameterType = ParameterType.Query)]
        // TODO: Not able to make enum nullable due to GetDescriptionAttribute logic blowing up.. fix this..
        public virtual DiscoverMovieSortBy? SortBy { get; set; } 

        /// <summary>
        /// Used in conjunction with the certification filter, use this
        /// to specify a country with a valid certification.
        /// </summary>
        [ApiParameter(
            Name = "certification_country",
            ParameterType = ParameterType.Query)]
        public virtual string CertificationCountry { get; set; }

        /// <summary>
        /// Filter results with a valid certification from the 'certification_country' field.
        /// </summary>
        [ApiParameter(
            Name = "certification",
            ParameterType = ParameterType.Query)]
        // TODO: Can we convert this to an enum value? Do the certification values ever change?
        public virtual string Certification { get; set; }

        /// <summary>
        /// Filter and only include movies that have a certification that
        /// is less than or equal to the specified value.
        /// </summary>
        [ApiParameter(
            Name = "certification.lte",
            ParameterType = ParameterType.Query)]
        // TODO: Can we convert this to an enum value? Do the certification values ever change?
        public virtual string CertificationLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a certification that
        /// is greater than or equal to the specified value.
        /// </summary>
        [ApiParameter(
            Name = "certification.gte",
            ParameterType = ParameterType.Query)]
        // TODO: Can we convert this to an enum value? Do the certification values ever change?
        public virtual string CertificationGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// A filter and include or exclude adult movies.
        /// </summary>
        [ApiParameter(
            Name = "include_adult",
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeAdult { get; set; }

        /// <summary>
        /// A filter to include or exclude videos.
        /// </summary>
        [ApiParameter(
            Name = "include_video",
            ParameterType = ParameterType.Query)]
        public virtual bool? IncludeVideo { get; set; }

        /// <summary>
        /// Specify the page of results to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Range(1, 1000)]
        public virtual int Page { get; set; }

        /// <summary>
        /// A filter to limit the results to a specific primary release year.
        /// </summary>
        [ApiParameter(
            Name = "primary_release_year",
            ParameterType = ParameterType.Query)]
        public virtual short? PrimaryReleaseYear { get; set; }

        /// <summary>
        /// Filter and only include movies that have a primary release date
        /// that is greater or equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "primary_release_date.gte",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.DateOnly)]
        public virtual DateTime? PrimaryReleaseDateGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a primary release date
        /// that is less than or equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "primary_release_date.lte",
            Option = SerializationOption.DateOnly,
            ParameterType = ParameterType.Query)]
        public virtual DateTime? PrimaryReleaseDateLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a release date
        /// (looking at all release dates) that is greater or
        /// equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "release_date.gte",
            Option = SerializationOption.DateOnly,
            ParameterType = ParameterType.Query)]
        public virtual DateTime? ReleaseDateGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a release date
        /// (looking at all release dates) that is less than or
        /// equal to the specified value.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "release_date.lte",
            Option = SerializationOption.DateOnly,
            ParameterType = ParameterType.Query)]
        public virtual DateTime? ReleaseDateLessThanOrEqualTo { get; set; }

        /// <summary>
        ///     minimum: 1
        ///     maximum: 6
        /// </summary>
        [ApiParameter(
            DelimeterLocation = nameof(WithReleaseTypesDelimeter),
            Name = "with_release_type",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<MovieReleaseType> WithReleaseTypes { get; set; }

        /// <summary>
        /// </summary>
        public virtual Delimeter WithReleaseTypesDelimeter { get; set; }

        /// <summary>
        /// A filter to limit the results to a specific year (looking at all release dates).
        /// </summary>
        [ApiParameter(
            Name = "year",
            ParameterType = ParameterType.Query)]
        public virtual short? Year { get; set; }

        /// <summary>
        /// Filter and only include movies that have a vote count that
        /// is greater or equal to the specified value.
        ///     minimum: 0
        /// </summary>
        [ApiParameter(
            Name = "vote_count.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteCountGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a vote count that
        /// is less than or equal to the specified value.
        ///     minimum: 0
        /// </summary>
        [ApiParameter(
            Name = "vote_count.lte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteCountLessThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a rating that is
        /// greater or equal to the specified value.
        ///     minimum: 1
        /// </summary>
        [ApiParameter(
            Name = "vote_average.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteAverageGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a rating that is less
        /// than or equal to the specified value.
        ///     minimum: 1
        /// </summary>
        [ApiParameter(
            Name = "vote_average.lte",
            ParameterType = ParameterType.Query)]
        public virtual int? VoteAverageLessThanOrEqualTo { get; set; }

        /// <summary>
        /// A comma separated list of person ID's. Only include movies that
        /// have one of the ID's added as an actor.
        /// </summary>
        [ApiParameter(
            Name = "with_cast",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithCastIds { get; set; }

        /// <summary>
        /// A comma separated list of person ID's. Only include movies that
        /// have one of the ID's added as a crew member.
        /// </summary>
        [ApiParameter(
            Name = "with_crew",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithCrewIds { get; set; }

        /// <summary>
        /// A comma separated list of person ID's. Only include movies that
        /// have one of the ID's added as a either a actor or a crew member.
        /// </summary>
        [ApiParameter(
            Name = "with_people",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithPeopleIds { get; set; }

        /// <summary>
        /// A comma separated list of production company ID's. Only include
        /// movies that have one of the ID's added as a production company.
        /// </summary>
        [ApiParameter(
            Delimeter = ',',
            Name = "with_companies",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithCompanyIds { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            DelimeterLocation = nameof(WithGenreIdsDelimeter),
            Name = "with_genres",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithGenreIds { get; set; }

        /// <summary>
        /// </summary>
        public virtual Delimeter WithGenreIdsDelimeter { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            DelimeterLocation = nameof(WithoutGenreIdsDelimeter),
            Name = "without_genres",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithoutGenreIds { get; set; }

        /// <summary>
        /// </summary>
        public virtual Delimeter WithoutGenreIdsDelimeter { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            DelimeterLocation = nameof(WithKeywordIdsDelimeter),
            Name = "with_keywords",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithKeywordIds { get; set; }

        /// <summary>
        /// </summary>
        public virtual Delimeter WithKeywordIdsDelimeter { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            DelimeterLocation = nameof(WithoutKeywordIdsDelimeter),
            Name = "without_keywords",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithoutKeywordIds { get; set; }

        /// <summary>
        /// </summary>
        public virtual Delimeter WithoutKeywordIdsDelimeter { get; set; }

        /// <summary>
        /// Filter and only include movies that have a runtime that is greater or equal to a value.
        /// </summary>
        [ApiParameter(
            Name = "with_runtime.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? WithRuntimeGreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Filter and only include movies that have a runtime that is less than or equal to a value.
        /// </summary>
        [ApiParameter(
            Name = "with_runtime.gte",
            ParameterType = ParameterType.Query)]
        public virtual int? WithRuntimeLessThanOrEqualTo { get; set; }

        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "with_original_language",
            ParameterType = ParameterType.Query)]
        public virtual string WithOriginalLanguageAbbreviation { get; set; }

        /// <summary>
        /// </summary>
        [ApiParameter(
            DelimeterLocation = nameof(WithWatchProviderIdsDelimeter),
            Name = "with_watch_providers",
            Option = SerializationOption.Delimeter,
            ParameterType = ParameterType.Query)]
        public virtual IEnumerable<int> WithWatchProviderIds { get; set; }

        /// <summary>
        /// </summary>
        public virtual Delimeter WithWatchProviderIdsDelimeter { get; set; }

        /// <summary>
        /// An ISO 3166-1 code. Combine this filter with with_watch_providers
        /// in order to filter your results by a specific watch provider
        /// in a specific region.
        /// </summary>
        [ApiParameter(
            Name = "watch_region",
            ParameterType = ParameterType.Query)]
        public virtual string WithWatchProviderRegionCountryCode { get; set; }
    }
}