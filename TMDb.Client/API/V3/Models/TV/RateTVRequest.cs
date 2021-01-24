using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.TV
{
    /// <summary>
    /// Rate a TV show.
    /// A valid session or guest session ID is required.You can read more about how this works.
    /// https://developers.themoviedb.org/3/authentication/how-do-i-generate-a-session-id
    /// </summary>
    [ApiPostEndpoint("/tv/{tv_id}/rating")]
    public class RateTVRequest : TVBaseRequest
    {
        /// <summary>
        /// default: application/json;charset=utf-8
        /// </summary>
        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        public virtual string ContentType => Constants.ContentType.Json;

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query)]
        public virtual string GuestSessionId { get; set; }

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
        [Range(0.5, 10)]
        [Required]
        public virtual float Rating { get; set; }
    }
}