using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.Movies
{
    [ApiGetEndpoint("/movie/{movie_id}/changes")]
    public class MovieChangesRequest : MovieBaseRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual int Page { get; set; }

        [ApiParameter(
            Name = "start_date",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Create Json Converter to convert the DateTime into Date format for serializing")]
        public virtual DateTime? StartDate { get; set; }

        [ApiParameter(
            Name = "end_date",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Create Json Converter to convert the DateTime into Date format for serializing")]
        public virtual DateTime? EndDate { get; set; }
    }
}