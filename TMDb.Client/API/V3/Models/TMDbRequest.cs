using Newtonsoft.Json;
using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models
{
    public abstract class TMDbRequest
    {
        [ApiParameter(
            Name = "api_key",
            ParameterType = ParameterType.Query)]
        [ApiParameter(
            Name = "api_key")]
        [JsonRequired]
        [Obsolete("// TODO: Move out of V3 folder")]
        public string ApiKey { get; set; }
    }
}