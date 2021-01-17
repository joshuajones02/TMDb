﻿using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Keywords
{
    public class KeywordDetailsRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "keyword_id",
            ParameterType = ParameterType.Query)]
        public virtual int KeywordId { get; set; }
    }
}