using System;
using System.Collections.Generic;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    /// <summary>
    /// Powered by our partnership with JustWatch, you can query this method to get a list of the availabilities per country by provider.
    /// This is not going to return full deep links, but rather, it's just enough information to display what's available where.
    /// You can link to the provided TMDb URL to help support TMDb and let your users deep link into the content.
    /// </summary>
    [ApiGetEndpoint("/movie/{movie_id}/watch/providers")]
    public class MovieWatchProvidersRequest : MovieBaseRequest
    {
    }
}
