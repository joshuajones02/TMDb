using System;
using TMDb.Client.Attributes;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiDeleteEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating")]
    public class DeleteTVEpisodeRatingRequest : TVEpisodesRequest, IGuestSession
    {
        //[ApiParameter(
        //    Name = "Content-Type",
        //    ParameterType = ParameterType.Header)]
        //public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }
    }
}