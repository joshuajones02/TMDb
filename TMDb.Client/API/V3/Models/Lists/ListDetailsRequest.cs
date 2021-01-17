using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Lists
{
    [ApiGetEndpoint("/list/{list_id}")]
    [Obsolete("// TODO: Move value to appsettings file")]
    public class ListDetailsRequest : ListRequestBase
    {
        [ApiParameter(
            Name = "language")]
        public virtual string LanguageAbbreviation { get; set; }
    }
}