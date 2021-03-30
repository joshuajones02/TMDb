using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Contracts
{
    public interface IRating
    {
        [ApiParameter(
            Name = "value",
            ParameterType = ParameterType.JsonBody)]
        // TODO: Set min (0.5) max (10) validation AND update all Rating properties to double
        [Range(0.5, 10)]
        [Required]
        double Rating { get; set; }
    }
}