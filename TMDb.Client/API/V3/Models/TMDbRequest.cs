using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models
{
    public abstract class TMDbRequest
    {
        [ApiParameter(
            Name = "api_key",
            ParameterType = ParameterType.Query)]
        [Required]
        [Obsolete("// TODO: Move out of V3 folder")]
        public virtual string ApiKey { get; set; }
    }
}