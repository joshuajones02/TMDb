using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Movies
{
    /// <summary>
    /// Get the most newly created movie. This is a live response and will continuously change.
    /// </summary>
    [ApiGetEndpoint("/movie/latest")]
    public class LatestMoviesRequest : TMDbRequest
    {
        /// <include file='tmdb-api-comments.xml' path='doc/members/member[@name="LanguageAbbreviation"]/*' />
        [ApiParameter(
            Name = "language",
            ParameterType = ParameterType.Query)]
        // TODO: Add null or 2 char count validation")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}