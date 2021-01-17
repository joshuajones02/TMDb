using Newtonsoft.Json;
using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiParameter(
        ParameterType = ParameterType.Endpoint,
        Value = "/list/{list_id}")]
    [Obsolete("// TODO: Move value to appsettings file")]
    public class ListDetailsRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "language")]
        public string LanguageAbbreviation { get; set; }
    }
}