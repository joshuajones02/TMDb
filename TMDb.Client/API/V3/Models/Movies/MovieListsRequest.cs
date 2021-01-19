using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    /// <summary>
    /// Get a list of lists that this movie belongs to.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/lists")]
    public class MovieListsRequest : MovieBaseRequest
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
        [Obsolete("// TODO: Add null or 2 char count validation")]
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
    }
}
