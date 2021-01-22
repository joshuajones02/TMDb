using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiDeleteEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating")]
    public class DeleteTVEpisodeRatingRequest : TVEpisodesRequest
    {
        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        public virtual string ContentType { get; set; }

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query)]
        public virtual string GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }
    }
}