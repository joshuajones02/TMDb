using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.TVEpisodes
{
    [ApiPostEndpoint("/tv/{tv_id}/season/{season_number}/episode/{episode_number}/rating")]
    public class RateTVEpisodeRequest : TVEpisodesRequest, IGuestSession
    {
        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }

        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        public virtual string SessionId { get; set; }

        /// <summary>
        /// This is the value of the rating you want to submit. The value is expected to be between 0.5 and 10.0.
        ///     minimum: 0.5
        ///     maximum: 10
        /// </summary>
        [ApiParameter(
            Name = "value",
            ParameterType = ParameterType.JsonBody)]
        // TODO: Set min (0.5) max (10) validation AND update all Rating properties to double
        [Range(0.5, 10)]
        [Required]
        public virtual float Rating { get; set; }
    }
}