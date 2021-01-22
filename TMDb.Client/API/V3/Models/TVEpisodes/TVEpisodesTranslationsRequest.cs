using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiGetEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/translations")]
    public class TVEpisodesTranslationsRequest : TVEpisodesRequest
    {
    }
}