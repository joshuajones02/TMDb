using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Contracts;

namespace TMDb.Client.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/account_states")]
    public class MovieAccountStatesRequest : MovieBaseRequest, IGuestSession
    {
        [ApiParameter(
            Name = "session_id",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "guest_session_id",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.NoHyphen)]
        public virtual Guid? GuestSessionId { get; set; }
    }
}