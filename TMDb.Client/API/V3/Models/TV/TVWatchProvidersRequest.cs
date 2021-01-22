using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TV
{
    /// <summary>
    /// Powered by our partnership with JustWatch, you can query this method to get a list of the availabilities per country by provider.
    /// This is not going to return full deep links, but rather, it's just enough information to display what's available where.
    /// You can link to the provided TMDb URL to help support TMDb and let your users deep link into the content.
    /// </summary>
    [ApiGetEndpoint("/tv/{tv_id}/watch/providers")]
    public class TVWatchProvidersRequest : TVBaseRequest
    {
    }
}