using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiParameter(
       ParameterType = ParameterType.Endpoint,
       Value = "/list/{list_id}/clear")]
    public class ClearListRequest : ListRequestBase
    {
        [ApiParameter(
           Name = "session_id",
           ParameterType = ParameterType.Query)]
        [Required]
        public string SessionId { get; set; }

        [ApiParameter(
            Name = "confirm",
            ParameterType = ParameterType.Query)]
        public bool Confirm { get; set; }
    }
}