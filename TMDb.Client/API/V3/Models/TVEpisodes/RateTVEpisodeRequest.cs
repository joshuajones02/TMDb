using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiPostEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating")]
    public class RateTVEpisodeRequest : TVEpisodesRequest
    {
    }
}