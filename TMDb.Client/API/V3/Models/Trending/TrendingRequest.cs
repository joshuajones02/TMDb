using System;
using TMDb.Client.Attributes;
using TMDb.Client.Enums;

namespace TMDb.Client.API.V3.Models.Trending
{
    [ApiGetEndpoint("/trending/{media_type}/{time_window}")]
    public class TrendingRequest : TMDbRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "media_type",
            ParameterType = ParameterType.Path)]
        [Obsolete("// TODO: Ensure this value is serializing as a string and not an int")]
        public virtual MediaType MediaType { get; set; }

        [ApiParameter(
            Name = "time_window",
            ParameterType = ParameterType.Path)]
        [Obsolete("// TODO: Ensure this value is serializing as a string and not an int")]
        public virtual TimeWindow TimeWindow { get; set; }
    }
}