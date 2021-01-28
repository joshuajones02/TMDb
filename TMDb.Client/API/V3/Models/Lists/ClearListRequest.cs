using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Lists
{
    [ApiPostEndpoint("/list/{list_id}/clear")]
    public class ClearListRequest : ListRequestBase
    {
        [ApiParameter(
           Name = "session_id",
           ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }

        [ApiParameter(
            Name = "confirm",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.ToLower)]
        public virtual bool Confirm { get; set; }
    }
}