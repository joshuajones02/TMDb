using TMDb.Client.Attributes;

namespace TMDb.Client.Contracts
{
    public interface ISession
    {
        [ApiParameter(
           Name = "session_id",
           ParameterType = ParameterType.Query)]
        string SessionId { get; set; }
    }
}