using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiParameter(
        ParameterType = ParameterType.Endpoint,
        Value = "/list/{list_id}")]
    public class DeleteListRequest : ListRequestBase
    {
        [ApiParameter(
           Name = "session_id",
           ParameterType = ParameterType.Query)]
        [Required]
        public virtual string SessionId { get; set; }
    }
}