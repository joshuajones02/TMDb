using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    /// <summary>
    /// Get the most newly created movie. This is a live response and will continuously change.
    /// </summary>
    [ApiGetEndpoint("/movie/latest")]
    public class LatestMoviesRequest : TMDbRequest
    {
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
    }
}
