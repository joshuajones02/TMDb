using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/account_states")]
    public class MovieAccountStatesRequest : MovieBaseRequest
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query)]
        public virtual string GuestSessionId { get; set; }
    }
}
