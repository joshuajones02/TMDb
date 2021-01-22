using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;
using TMDb.Client.Unions;

namespace TMDb.Client.Api.V3.Models.Lists
{
    public abstract class ListRequestBase : TMDbRequest
    {
        [ApiParameter(
            Name = "list_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual ListsIntStringIdUnion ListId { get; set; }
    }
}