using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API
{
    [Obsolete("on startup write check to make sure all members/propertyinfo have ApiParameter attribute")]
    public abstract class TMDbRequest
    {
        [ApiParameter(
            Name = "api_key",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual string ApiKey { get; set; }
    }
}