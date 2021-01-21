using TMDb.Client.Attributes;

namespace TMDb.Client.API.V3.Models.People
{
    [ApiGetEndpoint("/person/{person_id}/changes")]
    public class PeopleChangesRequest : PeopleRequest
    {
        [ApiParameter(
            Name = "page",
            ParameterType = ParameterType.Query)]
        public virtual string Page { get; set; }

        [ApiParameter(
            Name = "start_date",
            ParameterType = ParameterType.Query)]
        public virtual string StartDate { get; set; }

        [ApiParameter(
            Name = "end_date",
            ParameterType = ParameterType.Query)]
        public virtual string EndDate { get; set; }
    }
}