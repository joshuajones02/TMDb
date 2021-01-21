using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TVEpisodes
{
    [ApiPostEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating")]
    public class RateTVEpisodeRequest : TVEpisodesRequest
    {
    }
}