using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    [ApiPostEndpoint("/movie/{movie_id}/rating")]
    public class RateMovieRequest : MovieBaseRequest
    {
        /// <summary>
        /// default: application/json;charset=utf-8
        /// </summary>
        [ApiParameter(
            Name = "Content-Type",
            ParameterType = ParameterType.Header)]
        [Required]
        public virtual string ContentType { get; set; }

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
        [Required]
        public virtual string Rating { get; set; }
    }
}
