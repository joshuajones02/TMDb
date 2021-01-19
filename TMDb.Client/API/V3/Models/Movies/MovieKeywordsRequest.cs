using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    /// <summary>
    /// Get the keywords that have been added to a movie.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/keywords")]
    public class MovieKeywordsRequest : MovieBaseRequest
    {
    }
}
