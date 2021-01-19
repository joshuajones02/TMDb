using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    /// <summary>
    /// Get a list of upcoming movies in theatres. This is a release type query that looks for all movies that have a release type of 2 or 3 within the specified date range.
    /// You can optionally specify a region prameter which will narrow the search to only look for theatrical release dates within the specified country.
    /// </summary>
    [ApiGetEndpoint("/movie/upcoming")]
    public class UpcomingMoviesRequest : TMDbRequest
    {
        /// <summary>
        /// Specify which page to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }

        /// <summary>
        /// Pass a ISO 639-1 value to display translated data for the fields that support it.
        ///     minLength: 2
        ///     pattern: ([a - z]{2})-([A - Z]{2})
        ///     default: en - US
        /// </summary>
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Add null or 2 char count validation")]
        public virtual string LanguageAbbreviation { get; set; }

        /// <summary>
        /// Specify a ISO 3166-1 code to filter release dates. Must be uppercase.
        ///     pattern: ^[A-Z]{2}$
        /// </summary>
        [ApiParameter(
            Name = "region",
            ParameterType = ParameterType.Query)]
        public virtual string CountryCode { get; set; }
    }
}
