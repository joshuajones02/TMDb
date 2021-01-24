using System;
using TMDb.Client.Attributes;

namespace TMDb.Client.Api.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/changes")]
    public class PeopleChangesRequest : PeopleBaseRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual int Page { get; set; }

        /// <summary>
        /// Filter the results with a start date.
        ///     format: date
        /// </summary>
        // TODO: if both dates are used, add validation of <= 14 days
        // {"success":false,"status_code":20,"status_message":"Invalid date range: Should be a range no longer than 14 days."}
        [ApiParameter(
            Name = "start_date",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.DateOnly)]
        public virtual DateTime? StartDate { get; set; }

        /// <summary>
        /// Filter the results with a end date.
        ///     format: date
        /// </summary>
        // TODO: if both dates are used, add validation of <= 14 days
        // {"success":false,"status_code":20,"status_message":"Invalid date range: Should be a range no longer than 14 days."}
        [ApiParameter(
            Name = "end_date",
            ParameterType = ParameterType.Query,
            Option = SerializationOption.DateOnly)]
        public virtual DateTime? EndDate { get; set; }
    }
}