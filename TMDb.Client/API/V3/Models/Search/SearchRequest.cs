﻿using Newtonsoft.Json;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.Search
{
    public class SearchRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [JsonRequired]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "query",
            ParameterType = ParameterType.Query)]
        [JsonRequired]
        public virtual string Query { get; set; }
    }
}