using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Lists
{
    public abstract class ListRequestBase : TMDbRequest
    {
        [ApiParameter(
            Name = "list_id",
            ParameterType = ParameterType.Path)]
        [Required]
        public virtual int? ListId { get; set; }
    }
}