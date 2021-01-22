using System;
using System.ComponentModel.DataAnnotations;
using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.TV
{
    [ApiGetEndpoint("/tv/{tv_id}/changes")]
    public class TVChangesRequest : TVBaseRequest
    {
        /// <summary>
        /// Specify which page to query.
        ///     minimum: 1
        ///     maximum: 1000
        ///     default: 1
        /// </summary>
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        [Required]
        public virtual int Page { get; set; }

        /// <summary>
        /// Filter the results with a start date.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "start_date",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Create Json Converter to convert the DateTime into Date format for serializing")]
        public virtual DateTime? StartDate { get; set; }

        /// <summary>
        /// Filter the results with a end date.
        ///     format: date
        /// </summary>
        [ApiParameter(
            Name = "end_date",
            ParameterType = ParameterType.Query)]
        [Obsolete("// TODO: Create Json Converter to convert the DateTime into Date format for serializing")]
        public virtual DateTime? EndDate { get; set; }
    }
}