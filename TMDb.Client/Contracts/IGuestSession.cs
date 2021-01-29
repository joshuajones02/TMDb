using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.Contracts
{
    public interface IGuestSession
    {
        [ApiParameter(
           Name = "guest_session_id",
           ParameterType = ParameterType.Query,
           Option = SerializationOption.NoHyphen)]
        Guid? GuestSessionId { get; set; }
    }
}